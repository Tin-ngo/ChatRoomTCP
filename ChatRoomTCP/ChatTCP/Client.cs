using ChatTCP.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace ChatTCP
{
    public partial class Client : Form
    {
        IPEndPoint IP;
        Socket client;


        String name;
        String ip;
        int port;
        Form1_start F;

        // để gửi ảnh
        MemoryStream ms;  // tạo luòng có kho dự phòng là bộ nhớ
        NetworkStream ns;  // cung cấp luồng dữ liệu cơ bản để truy cập mạng
        BinaryWriter bw;     //Ghi các kiểu nguyên thủy ở dạng nhị phân vào một luồng và hỗ trợ viết các chuỗi trong một bảng mã cụ thể.

        String image_path;

        public Client(String Name, String IP, int Port, Form1_start frm, String imgName)
        {
            this.name = Name;
            this.ip = IP;
            this.port = Port;
            this.F = frm;
            this.image_path = imgName;

            InitializeComponent();

            //ảnh đại diện
            open_img_user = new OpenFileDialog();
            open_img_user.FileName = image_path;
            pictureBox1.Image = Image.FromFile(open_img_user.FileName);

            //xử lý lỗi đụng tài nguyên
            CheckForIllegalCrossThreadCalls = false; // khong cho check lỗi

            lbl_ThongtinCong.Text += port.ToString();
            lbl_ThongTinIP.Text += ip;
            lbl_ThongTinName.Text += name;

            Connect();
        }


        public int Connect()
        {
            //IP: địa chỉ của server
            String name_client = this.name;
            int port = this.port;
            String diachiIP = this.ip;
            if (diachiIP == "localhost") diachiIP = "127.0.0.1";
            try
            {
                IP = new IPEndPoint(IPAddress.Parse(diachiIP), port);
                // ổ cắm ở phía server
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP); // mặc định là phải ghi như vậy

                // giả sử connect không được
                try
                {
                    //kết nối với ổ cắm và địa chỉ phía server
                    client.Connect(IP);
                    //MessageBox.Show("Bạn đã gia nhập phòng chat", "Kết nối thành công với Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  client.Send(Serialize("User:" + name_client + " đã tham gia vào phòng chat"));

                    //

                    Image img = Image.FromFile(this.image_path); //open_img_user.FileName
                    client.Send(Serialize(img));

                    //
                    AddNotificationMessage("Bạn đã gia nhập phòng Chat " + client.RemoteEndPoint);
                    Show();
                }
                catch
                {
                    //Show (text, title, text của button, icon là error)
                    MessageBox.Show("Không thể kết nối", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form1_start f1 = new Form1_start();
                    f1.Show();
                    
                    return 0;  // không connect được thì cố connect lại
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối - Có thể là lỗi IP", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
                Close();
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            return 1;
        }


        void Close()
        {
            String name_client = this.name;
            if (client != null)
            {
                /*
                try
                {
                    client.Send(Serialize("Thongbao|" + name_client + " đã thoát khỏi phòng chat"));
                }
                catch
                {

                }
                */
                client.Close();
            }
        }



        void Receive()
        {

            // cố gắng nhận tin nếu có lỗi thì sẽ thực thi catch ở dưới
            try
            {
                while (true)   // nhận tin liên tục
                {
                    // 1024 byte * 5000  <=> 5mb
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);   // đã nhận được data

                    object obj = Deserialize(data);

                    if (obj.GetType().ToString() == "System.String")
                    {
                        // ép dữ liệu nhận đang ở dạng byte về kiểu object rồi ép thành kiểu string
                        string message = (string)Deserialize(data);
                        //đưa tin nhắn đã chuyển thành string lên khung chat
                        //AddReceiveMessage(message);
                        //nếu gửi icon (ký hiệu đặc biệt)
                        if (message == "icon1.jfif" || message == "icon2.jpg" || message == "icon3.png"
                            || message == "icon4.png" || message == "icon5.jfif" || message == "icon6.jfif")
                        {
                            add_icon_receive(message);
                        }
                        else
                        {
                            AddReceiveMessage(message);
                        }
                        

                    }

                    //nhận ảnh
                    if (obj.GetType().ToString() == "System.Drawing.Bitmap")
                    {
                        Image img = (Image)Deserialize(data);
                        Add_img_receive(img);
                    }
                    //hết nhận ảnh


                }
            }
            catch
            {
                client.Close();
                this.Hide();
                Form1_start f1 = new Form1_start();
                f1.Show();
                //MessageBox.Show("Đã Thoát khỏi phòng Chat");
            }
        }



        void Add_img_receive(Image img)
        {
            flowLayoutPanel1.Invoke(new Action(() =>
            {
                Image_Receive img_receive = new Image_Receive();
                img_receive.Image = img;
                flowLayoutPanel1.Controls.Add(img_receive);
            }));
        }

        public void Add_img_send(Image img)
        {
            flowLayoutPanel1.Invoke(new Action(() =>
            {
                Label lbl = new Label();
                Image_send img_send = new Image_send();
                img_send.Image = img;
                lbl.Width = 280;
                flowLayoutPanel1.Controls.Add(lbl);
                flowLayoutPanel1.Controls.Add(img_send);
            }));
        }

        void AddNotificationMessage(String s)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            flowLayoutPanel1.Invoke(new Action(() =>
            {
                Label lbl = new Label();
                lbl.Text = s;
                lbl.Width = flowLayoutPanel1.Width - 50;
                //lbl_sending.BackColor = Color.Blue;
                lbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                lbl.Height = 30;
                lbl.ForeColor = Color.Red;

                lbl.Padding = new System.Windows.Forms.Padding(5);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel1.Controls.Add(lbl);
                flowLayoutPanel1.AutoScroll = true;

                /*
                Label box_chat_me = new Label();
                flowLayoutPanel1.Controls.Add(box_chat_me);
                box_chat_me.Dock = DockStyle.Top;
                box_chat_me.Text = s;
                box_chat_me.BringToFront();
                flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
                */
            }));

        }


        void AddReceiveMessage(String s)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            flowLayoutPanel1.Invoke(new Action(() =>
            {
                /*
                Label box_chat_me = new Label();
                flowLayoutPanel1.Controls.Add(box_chat_me);
                box_chat_me.Dock = DockStyle.Top;
                box_chat_me.Text = s;
                box_chat_me.BringToFront();
                flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
                */

                /*
                Label lbl_receive = new Label();
                lbl_receive.Text = s;
                lbl_receive.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lbl_receive.Width = flowLayoutPanel1.Width - 30;
                //lbl_receive.BackColor = Color.Gray;
                lbl_receive.Height = 30;
                lbl_receive.ForeColor = Color.Black;
                lbl_receive.Padding = new System.Windows.Forms.Padding(5);
                flowLayoutPanel1.Controls.Add(lbl_receive);
                */

                // add text vào label
                Label lbl_sending = new Label();
                lbl_sending.Text = s;
                lbl_sending.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                //lbl_sending.Width = flowLayoutPanel1.Width - 30;
                //lbl_sending.BackColor = Color.Blue;
                lbl_sending.Height = 35;
                lbl_sending.Width = flowLayoutPanel1.Width - 90;
                lbl_sending.ForeColor = Color.Black;
                //lbl_sending.BackColor = Color.Gray;
                lbl_sending.Padding = new System.Windows.Forms.Padding(5);////////////////

                //add ảnh vào label
                Label ilabel = new Label();
                Image i = Image.FromFile("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\Image\\user.jfif"); //D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon1.jfif
                i = resizeImage(i, new Size(30, 30));
                //ilabel.Size = new Size(i.Width, i.Height);
                ilabel.Width = i.Width + 20;
                ilabel.Height = i.Height;
                //ilabel.ImageAlign = ContentAlignment.MiddleRight;
                ilabel.TextAlign = ContentAlignment.MiddleRight;
                ilabel.Image = i;

                //thêm label text vào trước rồi thêm label ahr vào sau
                //flowLayoutPanel1.Controls.Add(lbl);/////////////////////////
                flowLayoutPanel1.Controls.Add(ilabel);
                flowLayoutPanel1.Controls.Add(lbl_sending);
                flowLayoutPanel1.AutoScroll = true;


            }));
            txt_inputMess_client.Clear();
        }


        public void AddSendingMessage(string s)
        {
            if (!this.IsHandleCreated)
            {
                this.CreateHandle();
            }
            flowLayoutPanel1.Invoke(new Action(() =>
            {/*
                Mess_text_send mess_Text_Send = new Mess_text_send();
                mess_Text_Send.Message = s;
                flowLayoutPanel1.Controls.Add(mess_Text_Send);
                 */
                /*
                Label lbl_sending = new Label();
                lbl_sending.Text = s;
                lbl_sending.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lbl_sending.Width = flowLayoutPanel1.Width - 50;
                //lbl_sending.BackColor = Color.Blue;
                lbl_sending.Height = 30;
                lbl_sending.ForeColor = Color.Black;
                lbl_sending.Padding = new System.Windows.Forms.Padding(5);
                lbl_sending.TextAlign = ContentAlignment.MiddleRight;
                flowLayoutPanel1.Controls.Add(lbl_sending);
                flowLayoutPanel1.AutoScroll = true;
                */
                // add text vào label
                Label lbl_sending = new Label();
                lbl_sending.Text = s;
                lbl_sending.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                //lbl_sending.Width = flowLayoutPanel1.Width - 30;
                //lbl_sending.BackColor = Color.Blue;
                lbl_sending.Height = 35;
                lbl_sending.Width = flowLayoutPanel1.Width - 90;
                lbl_sending.ForeColor = Color.Blue;
                //lbl_sending.BackColor = Color.Gray;
                lbl_sending.Padding = new System.Windows.Forms.Padding(5);
                lbl_sending.TextAlign = ContentAlignment.MiddleRight;////////////////

                //add ảnh vào label
                Label ilabel = new Label();
                // Image i = Image.FromFile("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\Image\\user.jfif"); ảnh phụ- bản 1
                //Image i = Image.FromFile(open_img_user.FileName);
                Image i = Image.FromFile(this.image_path);
                i = resizeImage(i, new Size(30, 30));
                //ilabel.Size = new Size(i.Width, i.Height);
                ilabel.Width = i.Width + 20;
                ilabel.Height = i.Height;
                //ilabel.ImageAlign = ContentAlignment.MiddleRight;
                ilabel.TextAlign = ContentAlignment.MiddleRight;
                ilabel.Image = i;

                //thêm label text vào trước rồi thêm label ahr vào sau
                //flowLayoutPanel1.Controls.Add(lbl);/////////////////////////
                flowLayoutPanel1.Controls.Add(lbl_sending);
                flowLayoutPanel1.Controls.Add(ilabel);
                flowLayoutPanel1.AutoScroll = true;

            }));

            txt_inputMess_client.Clear();

        }


        byte[] Serialize(object obj)   // phân mảnh
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)   // gom mảnh
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        void Send()
        {
            String name_client = this.name;
            // nếu giá trị trong textbox không phải là rỗng
            if (txt_inputMess_client.Text != string.Empty)
            {
                // gửi theo kiểu byte - đã phân mảnh ra kiểu byte trong hàm Serialize rồi
                // gửi cái tin nhắn nhập trong textbox mà đa chuyển thành kiểu byte bằng hàm Serialize
                client.Send(Serialize(name_client + " : " + txt_inputMess_client.Text));
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_inputMess_client.Text != string.Empty)
            {
                Send();
                AddSendingMessage(txt_inputMess_client.Text);
            }
        }






        private void txt_inputMess_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            // Form1_start f1 = new Form1_start();
            //f1.Show();
            F.Show();
        }




        private void tab1_Click(object sender, EventArgs e)
        {

        }


        private void btn_emotes_Click(object sender, EventArgs e)
        {
            this.btn_emotes.Hide();
            this.Group_emote.Visible = true;
            this.btn_emotes_hide.Show();
            this.Group_emote.Show();
        }

        void hide_emotes()
        {
            this.btn_emotes_hide.Hide();
            this.Group_emote.Visible = false;
            this.Group_emote.Hide();
            this.btn_emotes.Show();
        }

        private void btn_emotes_hide_Click(object sender, EventArgs e)
        {
            hide_emotes();
        }

        private void icon1_Click(object sender, EventArgs e)
        {
            //loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon1.jfif");
            //hide_emotes();
            add_icon_send("icon1.jfif");
            Send_Method("icon1.jfif");
        }

        private void icon2_Click(object sender, EventArgs e)
        {
            //loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon2.jpg");
            //hide_emotes();
            add_icon_send("icon2.jpg");
            Send_Method("icon2.jpg");
        }

        private void icon3_Click(object sender, EventArgs e)
        {
            //loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon3.png");
            //hide_emotes();
            add_icon_send("icon3.png");
            Send_Method("icon3.png");
        }

        private void icon4_Click(object sender, EventArgs e)
        {
            //loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon4.png");
            //hide_emotes();
            add_icon_send("icon4.png");
            Send_Method("icon4.png");
        }

        private void icon5_Click(object sender, EventArgs e)
        {
            //loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon5.jfif");
            //hide_emotes();
            add_icon_send("icon5.jfif");
            Send_Method("icon5.jfif");
        }

        private void icon6_Click(object sender, EventArgs e)
        {
            ////AddSendingMessage("‪D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon6.jfif");
            //loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon6.jfif");
            //hide_emotes();
            add_icon_send("icon6.jfif");
            Send_Method("icon6.jfif");
        }


        //send icon
        void Send_Method(String s)
        {
            client.Send(Serialize(s));
        }




        void add_icon_send(String s)
        {
            loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\" + s);
            hide_emotes();
        }

        void add_icon_receive(String s)
        {
            loadimage_receive("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\" + s);
            hide_emotes();
        }



        private void loadimage_send(String s)
        {
            flowLayoutPanel1.Invoke(new Action(() =>
            {
                Label ilabel = new Label();
                Image i = Image.FromFile(s);

                i = resizeImage(i, new Size(60, 60));

                //ilabel.Size = new Size(i.Width, i.Height);
                ilabel.Width = i.Width + 20;
                ilabel.Height = i.Height;
                ilabel.ImageAlign = ContentAlignment.MiddleRight;
                ilabel.Image = i;
                //   this.Lv_ShowMess.Controls.Add(ilabel);
                Label lbl = new Label();
                lbl.Width = flowLayoutPanel1.Width - (ilabel.Width + 50);
                flowLayoutPanel1.Controls.Add(lbl);
                flowLayoutPanel1.Controls.Add(ilabel);
            }));

        }

        private void loadimage_receive(String s)
        {
            flowLayoutPanel1.Invoke(new Action(() =>
            {
                Label ilabel = new Label();
                Image i = Image.FromFile(s);

                i = resizeImage(i, new Size(60, 60));

                //ilabel.Size = new Size(i.Width, i.Height);
                ilabel.Width = i.Width + 50;
                ilabel.Height = i.Height;
                // ilabel.ImageAlign = ContentAlignment.MiddleRight;
                ilabel.Image = i;
                //   this.Lv_ShowMess.Controls.Add(ilabel);
                Label lbl = new Label();
                lbl.Width = flowLayoutPanel1.Width - (ilabel.Width + 50);
                flowLayoutPanel1.Controls.Add(ilabel);
                flowLayoutPanel1.Controls.Add(lbl);
            }));

        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            openFileImage.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico;*.jfif";
            openFileImage.Multiselect = false;
            openFileImage.FileName = "";
            DialogResult result = openFileImage.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileImage.FileName.ToString());
                if (fi.Length > 1024 * 5000)
                {
                    MessageBox.Show("Kích thước ảnh không được lớn hơn 5MB");
                    return;
                }
                Image img = Image.FromFile(openFileImage.FileName);

                client.Send(Serialize(img));
                // thêm hình ảnh vô nơi gửi
                /*
                pictureBox_image.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_image.Image = Image.FromFile(openFileImage.FileName);
                */
                Add_img_send(img);
            }
            else
            {
                return;
            }
        }

        OpenFileDialog open_img_user;
        private void btn_img_user_client_Click(object sender, EventArgs e)
        {
            open_img_user.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.jfif";
            if (open_img_user.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(open_img_user.FileName);
                i = resizeImage(i, new Size(260, 260));
                pictureBox1.Image = i;
                this.image_path = open_img_user.FileName;
            }
        }
    }
}
