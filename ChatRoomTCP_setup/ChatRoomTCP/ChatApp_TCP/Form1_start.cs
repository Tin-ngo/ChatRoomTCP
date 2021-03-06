using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_TCP
{
    public partial class Form1_start : Form
    {
        Client Client_join;
        //Host - Server
        Server srv;
        public int port = 9999;

        OpenFileDialog open_img_user;
        //gửi đường dẫn ảnh
        String path_img;

        public Form1_start()
        {
            InitializeComponent();
            giaodiendau();

            open_img_user = new OpenFileDialog();
            open_img_user.FileName = "D:\\CSharp\\ChatRoomTCP\\ChatRoomTCP\\Image\\user.jfif";
            this.path_img = open_img_user.FileName;
            pictureBox2.Image = Image.FromFile(open_img_user.FileName);

            // lấy tên của  máy tính
            txtb_name_start.Text = System.Environment.MachineName;

            txtb_portStart.Text = "9999";
            txtb_portStart.Enabled = false;

            txtb_ipStart.Text = "localhost"; //"localhost";
            //txtb_ipStart.Enabled = false;

            //host
            txt_nameHost.Text = "Host";

            txt_ipHost.Text = getIPAddress();//"127.0.0.1";
            //txt_ipHost.Enabled = false;

            txt_portHost.Text = "9999";
            txt_portHost.Enabled = false;

        }



        void giaodiendau()
        {
            lbl_IpStart.Hide();
            lbl_portStart.Hide();
            txtb_ipStart.Hide();
            txtb_portStart.Hide();
            lbl_welCome.Hide();
            txtb_name_start.Hide();
            label1.Hide();
            btn_cancel_Start.Hide();
            btn_start.Hide();
            pictureBox2.Hide();
            btn_img_user.Hide();

            lbl_nameHost.Hide();
            lbl_portHost.Hide();
            lbl_ipHost.Hide();
            txt_nameHost.Hide();
            txt_portHost.Hide();
            txt_ipHost.Hide();
            btn_cancelHost.Hide();
            btn_connectHost.Hide();
        }

        private void btn_cancel_Start_Click(object sender, EventArgs e)
        {
            //Close();
            btn_Joinchat.Show();
            btn_newchat.Show();
            pictureBox1.Show();

            lbl_IpStart.Hide();
            lbl_portStart.Hide();
            txtb_ipStart.Hide();
            txtb_portStart.Hide();
            lbl_welCome.Hide();
            txtb_name_start.Hide();
            label1.Hide();
            btn_cancel_Start.Hide();
            btn_start.Hide();
            pictureBox2.Hide();
            btn_img_user.Hide();
        }

        private void btn_Joinchat_Click(object sender, EventArgs e)
        {
            btn_Joinchat.Hide();
            btn_newchat.Hide();
            pictureBox1.Hide();

            lbl_IpStart.Show();
            lbl_portStart.Show();
            txtb_ipStart.Show();
            txtb_portStart.Show();
            lbl_welCome.Show();
            txtb_name_start.Show();
            label1.Show();
            btn_cancel_Start.Show();
            btn_start.Show();
            pictureBox2.Show();
            btn_img_user.Show();
        }

        private void btn_newchat_Click(object sender, EventArgs e)
        {
            btn_Joinchat.Hide();
            btn_newchat.Hide();

            lbl_welCome.Show();
            lbl_nameHost.Show();
            lbl_portHost.Show();
            lbl_ipHost.Show();
            txt_nameHost.Show();
            txt_portHost.Show();
            txt_ipHost.Show();
            btn_cancelHost.Show();
            btn_connectHost.Show();
        }

        private void btn_cancelHost_Click(object sender, EventArgs e)
        {
            btn_Joinchat.Show();
            btn_newchat.Show();

            lbl_welCome.Hide();
            lbl_nameHost.Hide();
            lbl_portHost.Hide();
            lbl_ipHost.Hide();
            txt_nameHost.Hide();
            txt_portHost.Hide();
            txt_ipHost.Hide();
            btn_cancelHost.Hide();
            btn_connectHost.Hide();
        }

        string getIPAddress()
        {
            return Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }


        //join

        private void btn_start_Click(object sender, EventArgs e)
        {
            int port_JOIN = int.Parse(txtb_portStart.Text);
            String diachiIP_JOIN = txtb_ipStart.Text;
            String name_JOIN = txtb_name_start.Text;
            if (diachiIP_JOIN == "localhost") diachiIP_JOIN = "127.0.0.1";

            Client_join = new Client(name_JOIN, diachiIP_JOIN, port_JOIN, this, this.path_img);
            Client_join.Show();
            this.Hide();
        }

        //host
        private void btn_connectHost_Click(object sender, EventArgs e)  //Server
        {
            String namehost = txt_nameHost.Text;
            String IPhost = txt_ipHost.Text;
            int PortHost = int.Parse(txt_portHost.Text);

            srv = new Server(namehost, IPhost, PortHost, this);
            srv.Show();
            this.Hide();
        }

        private void Form1_start_Load(object sender, EventArgs e)
        {

        }

        private void Form1_start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (srv != null)
            {
                srv.Close();
            }
            if (Client_join != null)
            {
                Client_join.Close();
            }
        }

        private void btn_img_user_Click(object sender, EventArgs e)
        {
            open_img_user.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.jfif";
            if (open_img_user.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(open_img_user.FileName);
                //MessageBox.Show(open_img_user.FileName);
                pictureBox2.Image = i;
                this.path_img = open_img_user.FileName;
            }
        }
    }
}
