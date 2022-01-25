using ChatApp_TCP;
using ChatTCP.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatApp_TCP
{
    public partial class Server : Form
    {
        IPEndPoint IP;
        Socket server;
        List<Socket> ClientList;

        List<Image> ClientImage; // lưu ảnh client
        List<int> PortClient;   // lưu cổng client
        int port_client;          // lưu cổng client để so sánhs
        int i;            // để lưu key


        public int port;
        public String name;
        public String ip;
        Form1_start F;

        String tinnhan = "";

        Image img_client;

        //nhận tên của user
        List<String> list_name_User = new List<string>();

        String NameFile_Receivel = "";



        public Server(String name, String IP, int Port, Form1_start frm)
        {
            this.port = Port;
            this.name = name;
            this.ip = IP;
            this.F = frm;

            InitializeComponent(); 
            open_img_user = new OpenFileDialog();
            open_img_user.FileName = "D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\Image\\user.jfif";
            pictureBox1.Image = Image.FromFile(open_img_user.FileName);

            this.Group_emote.Hide();
            this.btn_emotes_hide.Hide();
            CheckForIllegalCrossThreadCalls = false;

            lbl_ThongtinCong.Text += Port.ToString();
            lbl_ThongTinIP.Text += IP;
            lbl_ThongTinName.Text += name;
            
            Connect();

        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
            // Form1_start frm = new Form1_start();
            // frm.Show();
            F.Show();
        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (ClientList != null && txt_inputMess.Text != string.Empty)
            {
                foreach (Socket item in ClientList)
                {
                    Send(item);
                }
                /*
                for(int i = 0; i < ClientList.Count; i++)//ClientImage
                {
                    Send(ClientList[i]);
                }
                */

                AddSendingMessage(txt_inputMess.Text);
                txt_inputMess.Clear();


            }
            else
            {
                Console.WriteLine("loi");
            }

        }

        void Connect()
        {
            ClientList = new List<Socket>();
            ClientImage = new List<Image>();
            PortClient = new List<int>();

            AddNotificationMessage("Phòng Chat Đã Sẵn Sàng ...", Color.Blue);

            IP = new IPEndPoint(IPAddress.Any, port);
            //IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // mặc định là phải ghi như vậy

            server.Bind(IP);

            Thread Listen = new Thread(() => {
            try
            {
                while (true)
                {
                    server.Listen(100);
                    Socket client = server.Accept();
                    ClientList.Add(client);
                        // AddNotificationMessage(client.RemoteEndPoint.ToString() + " Đã tham gia vào phòng chat");

                        //nhận ảnh đại diện
                        byte[] data = new byte[1024 * 5000];
                        client.Receive(data);
                        object obj_receive = Deserialize(data);
                        if (obj_receive.GetType().ToString() == "System.Drawing.Bitmap")
                        {
                            Image img = (Image)Deserialize(data);
                            this.img_client = img;

                            // thêm cổng vafo để xác định ảnh dựa vào key của danh sách
                            String client_RemoteEndPoint = client.RemoteEndPoint.ToString();
                            string str = ":";
                            char[] characters4 = str.ToCharArray();
                            String[] port_client = client_RemoteEndPoint.Split(characters4);
                            PortClient.Add(Int32.Parse(port_client[1]));

                            ClientImage.Add(img);
                        }



                        //String socket_clientconnect = client.RemoteEndPoint.ToString();
                        //String port_clientconnect = socket_clientconnect.Substring(socket_clientconnect.Length - 1, 1);

                        //RemoteEndPoint : lấy ip của server và cổng của ứng dụng client
                        //LocalEndPoint : lấy ip và cổng của client đã kết nối tới

                        /* thêm danh sách các user vô theo dạng remotepoint
                        list_all.Items.Clear();
                        foreach (Socket item in ClientList)
                        {
                            list_all.Items.Add(item.RemoteEndPoint.ToString());
                        }
                        */

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    // mặc định là phải ghi như vậy
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP); 
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }


        void Close()
        {
            if (server != null)
            {
                server.Close();
            }
        }


        void Send(Socket client)
        {
            if (client != null && txt_inputMess.Text != string.Empty)
                // client.Send(Serialize(lbl_ThongTinName.Text+": " + txt_inputMess.Text));
                client.Send(Serialize(txt_inputMess.Text));
        }


        /*
        void Receive dùng chính(Object obj)
        {
            Socket client = obj as Socket;
            // cố gắng nhận tin nếu có lỗi thì sẽ thực thi catch ở dưới
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    object obj_receive = Deserialize(data);

                    if (obj_receive.GetType().ToString() == "System.String")
                    {
                        string message = (string)Deserialize(data);
                        // để hiển thị tin nhắn của client lên tất cả client còn lại
                        foreach (Socket item in ClientList)
                        {
                            //item != null (nếu tin nhắn khác null)  && item!= client (và nếu tin nhắn khác của client đang gửi)
                            if (item != null && item != client)
                                item.Send(Serialize(message));
                        }
                        if (message != null && message != "")
                        {
                            //GetMessage(message);
                            this.tinnhan = message;
                            Label lbl_receive = new Label();
                            lbl_receive.Text = this.tinnhan;
                            //AddReceiveMessage(message);
                            if (message == "icon1.jfif" || message == "icon2.jpg" || message == "icon3.png"
                                || message == "icon4.png" || message == "icon5.jfif" || message == "icon6.jfif")
                            {
                                add_image_receive(message);
                            }
                            else
                            {
                                String RemoteEndPoint = client.RemoteEndPoint.ToString();
                                String[] port = RemoteEndPoint.Split(":");
                                port_client = Int32.Parse(port[1]);
                                i = kiemtra(PortClient, port_client);
                                AddReceiveMessage(message); // + client.RemoteEndPoint
                            }
                            
                            
                        }
                    } //end if

                    //nhận ảnh
                    if (obj_receive.GetType().ToString() == "System.Drawing.Bitmap")
                    {

                        Image img = (Image)Deserialize(data);
                        // gửi hết cho toàn  client
                        foreach (Socket item in ClientList)
                        {
                            if (client != null && item != client)
                            {
                                item.Send(Serialize(img));
                            }

                        }
                        Add_img_receive(img);
                    }
                }
            }
            catch
            {
                ClientList.Remove(client);
                AddNotificationMessage(client.RemoteEndPoint + ": đã thoát khỏi phòng Chat");
                //list_all.Items.Remove(client.RemoteEndPoint);
                list_all.Items.Clear();
                foreach (Socket item in ClientList)
                {
                    list_all.Items.Add(item.RemoteEndPoint.ToString());
                }
                client.Close();
            }
        }
        */

        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            // cố gắng nhận tin nếu có lỗi thì sẽ thực thi catch ở dưới
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int receivedBytesLen = client.Receive(data);

                    try
                    {
                        object obj_receive = Deserialize(data);

                        if (obj_receive.GetType().ToString() == "System.String")
                        {
                            string message = (string)Deserialize(data);
                            // để hiển thị tin nhắn của client lên tất cả client còn lại
                            

                            if (message != null && message != "")
                            {
                                //GetMessage(message);
                                NameFile_Receivel = message;
                                this.tinnhan = message;
                                Label lbl_receive = new Label();
                                lbl_receive.Text = this.tinnhan;
                                //lấy tên client
                                try
                                {
                                    string str = "==";
                                    char[] characters = str.ToCharArray();

                                    String[] name_client = message.Split(characters);
                                    if(name_client[0] == "GuiRieng")
                                    {
                                        list_ChatRieng.Items.Add(name_client[1]);
                                    }
                                    else
                                    {
                                        list_name_User.Add(name_client[1]);
                                        list_all_name.Items.Clear();
                                        foreach (String item in list_name_User)
                                        {
                                            list_all_name.Items.Add(item);
                                        }
                                        AddNotificationMessage(name_client[1] + " Đã tham gia vào phòng chat", Color.Blue);
                                    }
                                }
                                catch
                                {
                                    foreach (Socket item in ClientList)
                                    {
                                        //item != null (nếu tin nhắn khác null)  && item!= client (và nếu tin nhắn khác của client đang gửi)
                                        if (item != null && item != client)
                                            item.Send(Serialize(message));
                                    }

                                    //AddReceiveMessage(message);

                                    if (message == "icon1.jfif" || message == "icon2.jpg" || message == "icon3.png"
                                        || message == "icon4.png" || message == "icon5.jfif" || message == "icon6.jfif")
                                    {
                                        add_image_receive(message);
                                    }
                                    else
                                    {
                                        String RemoteEndPoint = client.RemoteEndPoint.ToString();
                                        string str = ":";
                                        char[] characters2 = str.ToCharArray();
                                        String[] port = RemoteEndPoint.Split(characters2);
                                        port_client = Int32.Parse(port[1]);
                                        i = kiemtra(PortClient, port_client);
                                        AddReceiveMessage(message); // + client.RemoteEndPoint
                                    }

                                }

                            }
                        } //end if

                        //nhận ảnh
                        if (obj_receive.GetType().ToString() == "System.Drawing.Bitmap")
                        {

                            Image img = (Image)Deserialize(data);
                            // gửi hết cho toàn  client
                            foreach (Socket item in ClientList)
                            {
                                if (client != null && item != client)
                                {
                                    item.Send(Serialize(img));
                                }

                            }
                            Add_img_receive(img);
                        }

                    }
                    catch
                    {
                        this.Invoke(new Action(() =>
                        {
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                            saveFileDialog1.FilterIndex = 2;
                            saveFileDialog1.FileName = NameFile_Receivel;
                            saveFileDialog1.RestoreDirectory = true;

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                //MessageBox.Show(saveFileDialog1.FileName.ToString());
                                int fileNameLen = BitConverter.ToInt32(data, 0);
                                string fileName = saveFileDialog1.FileName.ToString();// Encoding.ASCII.GetString(data, 4, fileNameLen);
                                BinaryWriter bWrite = new BinaryWriter(File.Open(fileName, FileMode.Create));
                                bWrite.Write(data, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);
                                bWrite.Close();
                                foreach (Socket item in ClientList)
                                {
                                    if (item != null && item != client)
                                    {
                                        //Send(item);/
                                        Send_File(item, fileName);
                                        Send(item);
                                    }
                                }
                            }
                            String mess_file = saveFileDialog1.FileName;
                            //String[] words = mess_file.Split("\");

                           // AddReceiveMessage(words[words.Length - 1]);
                        }));
                    }
                    
                }
            }
            catch
            {
                int i = ClientList.IndexOf(client);
                //MessageBox.Show(i.ToString());
                ClientList.Remove(client);
                AddNotificationMessage(client.RemoteEndPoint + ": đã thoát khỏi phòng Chat", Color.Red);
                //list_all.Items.Remove(client.RemoteEndPoint);
                /* khi có người rời thì tiến hành lập lại danh sách
                list_all.Items.Clear();
                foreach (Socket item in ClientList)
                {
                    list_all.Items.Add(item.RemoteEndPoint.ToString());
                }
                */
                list_name_User.RemoveAt(i);
                list_all_name.Items.Clear();
                foreach (String item in list_name_User)
                {
                    list_all_name.Items.Add(item);
                }
                client.Close();
            }
        }





        //nâng cao
        void AddNotificationMessage(String s, Color color)
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
                lbl.ForeColor = color;
                
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

                /* bản chính 1 - cơ bản
                Label lbl_receive = new Label();
                lbl_receive.Text = s;
                lbl_receive.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lbl_receive.Width = flowLayoutPanel1.Width - 50;
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
                //ilabel.Image = i;
                /* 2 dìng dưới là bản 1 bị lỗi khi 2 client đều gửi
                img_client = resizeImage(img_client, new Size(30, 30));
                ilabel.Image = img_client;
                */
                ClientImage[this.i] = resizeImage(ClientImage[this.i], new Size(30, 30));
                ilabel.Image = ClientImage[this.i];

                //thêm label text vào trước rồi thêm label ahr vào sau
                //flowLayoutPanel1.Controls.Add(lbl);/////////////////////////
                flowLayoutPanel1.Controls.Add(ilabel);
                flowLayoutPanel1.Controls.Add(lbl_sending);
                flowLayoutPanel1.AutoScroll = true;

            }));

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
                Label ilabel = new Label();
                Image i = Image.FromFile("D:\\CSharp\\ChatRoomTCP\\Image\\user.jfif"); //D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon1.jfif
                i = resizeImage(i, new Size(60, 60));
                //ilabel.Size = new Size(i.Width, i.Height);
                ilabel.Width = i.Width + 20;
                ilabel.Height = i.Height;
                //ilabel.ImageAlign = ContentAlignment.MiddleRight;
                ilabel.TextAlign = ContentAlignment.MiddleRight;
                ilabel.Image = i;
                //   this.Lv_ShowMess.Controls.Add(ilabel);
                flowLayoutPanel1.Controls.Add(ilabel);
                */

                /*chính
                Label lbl_sending = new Label();
                lbl_sending.Text = s;
                lbl_sending.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lbl_sending.Width = flowLayoutPanel1.Width - 30;
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
                //Image i = Image.FromFile("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\Image\\user.jfif"); // phụ
                Image i = Image.FromFile(open_img_user.FileName);
                //pictureBox3.Image = i;   // test
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
                lbl.Width = 250;
                flowLayoutPanel1.Controls.Add(lbl);
                flowLayoutPanel1.Controls.Add(img_send);
            }));
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

        private void Server_Load(object sender, EventArgs e)
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
            add_image_send("icon1.jfif");
            Send_Method("icon1.jfif");
        }

        private void icon2_Click(object sender, EventArgs e)
        {
            add_image_send("icon2.jpg");
            Send_Method("icon2.jpg");
        }

        private void icon3_Click(object sender, EventArgs e)
        {
            add_image_send("icon3.png");
            Send_Method("icon3.png");
        }

        private void icon4_Click(object sender, EventArgs e)
        {
            add_image_send("icon4.png");
            Send_Method("icon4.png");
        }

        private void icon5_Click(object sender, EventArgs e)
        {
            add_image_send("icon5.jfif");
            Send_Method("icon5.jfif");
        }

        private void icon6_Click(object sender, EventArgs e)
        {
            //AddSendingMessage("‪D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\icon6.jfif");
            add_image_send("icon6.jfif");
            Send_Method("icon6.jfif");
            
        }

        //để gửi icon - gửi tên của icon - kiểm tra socket client khác null thì gửi string s
        void Send_Method(String s)
        {
            if (ClientList != null)
            {
                foreach (Socket item in ClientList)
                {
                    if (item != null)
                        item.Send(Serialize(s));
                }
            }
            else
            {
                Console.WriteLine("loi");
            }
        }


        // hiển thị icon lên flowlayoutpanel bên trái - nhận
        void add_image_receive(String s)
        {
            loadimage_receive("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\" + s);
            hide_emotes();
        }

        //hiển thị icon lên flowlayoutpanel bên phải - gửi
        void add_image_send(String s)
        {
            loadimage_send("D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\icon\\" + s);
            hide_emotes();
        }

        private void loadimage_send(String s)
        {
            Label ilabel = new Label();
            Image i = Image.FromFile(s);

            i = resizeImage(i, new Size(60, 60));

            //ilabel.Size = new Size(i.Width, i.Height);
            ilabel.Width = i.Width+20;
            ilabel.Height = i.Height;
            ilabel.ImageAlign = ContentAlignment.MiddleRight;
            ilabel.Image = i;
            //   this.Lv_ShowMess.Controls.Add(ilabel);
            Label lbl = new Label();
            lbl.Width = flowLayoutPanel1.Width - (ilabel.Width + 50);
            flowLayoutPanel1.Controls.Add(lbl);
            flowLayoutPanel1.Controls.Add(ilabel);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //gửi ảnh

        private void btn_image_Click(object sender, EventArgs e)
        {
            /*
            // hiển thị hình ảnh bên gửi
            pictureBox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            //MessageBox.Show(path);
            pictureBox_image.Image = Image.FromFile(path);
            */

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

                foreach (Socket item in ClientList)
                {
                    item.Send(Serialize(img));
                }
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
        /// hết gửi ảnh



        ///Gửi file

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            //openFileImage.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico;*.jfif";
            openFileImage.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;
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
                // MessageBox.Show(openFileImage.FileName.ToString());
                //MessageBox.Show(openFileImage.SafeFileName.ToString());
                txt_inputMess.Text = openFileImage.SafeFileName.ToString();
                if (openFileImage.SafeFileName.ToString() != null)
                {
                    foreach (Socket item in ClientList)
                    {
                        //Send(item);/
                        Send_File(item, openFileImage.FileName.ToString());
                        Send(item);
                    }
                    AddSendingMessage(txt_inputMess.Text);
                    txt_inputMess.Clear();
                }
                else
                {
                    Console.WriteLine("loi");
                }

                //////////////////
            }
            else
            {
                return;
            }

        }



        public void Send_File(Socket client, String path)
        {
            string fileName = path;// "c:\\filetosend.txt";
            byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
            byte[] fileData = File.ReadAllBytes(fileName); //file để gửi
            byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];

            fileNameLen.CopyTo(clientData, 0);
            fileNameByte.CopyTo(clientData, 4);
            fileData.CopyTo(clientData, 4 + fileNameByte.Length);
            try
            {
                client.Send(clientData);
            }
            catch
            {
                MessageBox.Show("Lỗi gửi file");
            }
        }

        ///hết gửi file




        // đổi ảnh đại diện

        OpenFileDialog open_img_user;
        private void btn_doianh_Click(object sender, EventArgs e)
        {
            open_img_user.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open_img_user.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(open_img_user.FileName);
                i = resizeImage(i, new Size(260, 260));
                pictureBox1.Image = i;
            }
        }







        //thử nghiệm
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Mess_text_send mess = new Mess_text_send();
            mess.Message = "Hello kjlgjdfg đây là tin nhắn bạn vừa gửi ..        ... ";
            flowLayoutPanel1.Controls.Add(mess);
            */
            Label lbl_sending = new Label();
            lbl_sending.Text = "Hello kjlgjdfg đây là tin nhắn bạn vừa gửi";
            lbl_sending.Width = flowLayoutPanel1.Width - 50;
            lbl_sending.BackColor = Color.Blue;
            lbl_sending.Height = 40;
            lbl_sending.ForeColor = Color.Black;
            lbl_sending.Padding = new System.Windows.Forms.Padding(10);
            lbl_sending.TextAlign = ContentAlignment.MiddleRight;
            flowLayoutPanel1.Controls.Add(lbl_sending);
            flowLayoutPanel1.AutoScroll = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*
             Mess_Text_Receive mess = new Mess_Text_Receive();
             mess.Message = "Hello hkhksadfgdfgfg  đây là tin nhắn bạn vừa nhận  .";
             flowLayoutPanel1.Controls.Add(mess);
            */
            Label lbl_sending = new Label();
            lbl_sending.Text = "Hello kjlgjdfg đây là tin nhắn bạn vừa Nhận từ client khác";
            lbl_sending.Width = flowLayoutPanel1.Width - 50;
            lbl_sending.BackColor = Color.Gray;
            lbl_sending.Height = 40;
            lbl_sending.ForeColor = Color.Black;
            lbl_sending.Padding = new System.Windows.Forms.Padding(10);
            flowLayoutPanel1.Controls.Add(lbl_sending);
        }


        //để lấy cổng dựa vào key i
        int kiemtra(List<int> listport, int port)
        {
            int i;
            for (i = 0; i < listport.Count; i++)
            {
                if (listport[i] == port)
                {
                    return i;
                }
            }
            return i;
        }




        // Gửi tin nhắn riêng

        Socket Client_ChatRieng;
        int index_ChatRieng;
        //get infomation of user in listbox
        private void list_all_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(list_all_name.SelectedItem.ToString());
            //MessageBox.Show(list_all_name.SelectedIndex.ToString());
            MessageBox.Show("Lấy thông tin của " + list_all_name.SelectedItem.ToString());
            int index;
            //lấy chỉ mục khi nhấn vào item
            index = list_all_name.SelectedIndex;
            String Client_remoteendPoint = ClientList[index].RemoteEndPoint.ToString();
            string str = ":";
            char[] character3 = str.ToCharArray();
            String[] array_socket = Client_remoteendPoint.Split(character3);
            textBox1.Text = array_socket[0];
            textBox2.Text = array_socket[1];
            textBox3.Text = ClientList[index].RemoteEndPoint.ToString();
            textBox4.Text = list_all_name.SelectedItem.ToString();
            //Send(ClientList[index]);  gửi được tin nhắn cho 1 client
            Client_ChatRieng = ClientList[index];
            index_ChatRieng = index;
        }

        void Send_rieng(Socket client)
        {
            if (client != null && txt_input_ChatRieng.Text != string.Empty)
                // client.Send(Serialize(lbl_ThongTinName.Text+": " + txt_inputMess.Text));
                client.Send(Serialize("GuiRieng=="+txt_input_ChatRieng.Text));
        }

        private void btn_send_ChatRieng_Click(object sender, EventArgs e)
        {
            if (Client_ChatRieng!= null && txt_input_ChatRieng != null)
            {
                Send_rieng(Client_ChatRieng);
            }
            list_ChatRieng.Items.Add("Bạn: "+txt_input_ChatRieng.Text);
            txt_input_ChatRieng.Clear();
        }

        private void tab2_Click(object sender, EventArgs e)
        {

        }



        //hết chat riêng


    }
}
