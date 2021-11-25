
using System.Windows.Forms;

namespace ChatTCP
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btn_image = new System.Windows.Forms.Button();
            this.Group_emote = new System.Windows.Forms.GroupBox();
            this.icon6 = new System.Windows.Forms.PictureBox();
            this.icon5 = new System.Windows.Forms.PictureBox();
            this.icon4 = new System.Windows.Forms.PictureBox();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_emotes_hide = new System.Windows.Forms.Button();
            this.btn_emotes = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_inputMess = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_doianh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ThongTinName = new System.Windows.Forms.Label();
            this.lbl_ThongTinIP = new System.Windows.Forms.Label();
            this.lbl_ThongtinCong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.list_all = new System.Windows.Forms.ListBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.Group_emote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 356);
            this.tabControl1.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_image);
            this.tab1.Controls.Add(this.Group_emote);
            this.tab1.Controls.Add(this.flowLayoutPanel1);
            this.tab1.Controls.Add(this.btn_emotes_hide);
            this.tab1.Controls.Add(this.btn_emotes);
            this.tab1.Controls.Add(this.btn_Send);
            this.tab1.Controls.Add(this.txt_inputMess);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(656, 328);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Message";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btn_image
            // 
            this.btn_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_image.Location = new System.Drawing.Point(573, 299);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(75, 23);
            this.btn_image.TabIndex = 5;
            this.btn_image.Text = "Ảnh";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // Group_emote
            // 
            this.Group_emote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_emote.Controls.Add(this.icon6);
            this.Group_emote.Controls.Add(this.icon5);
            this.Group_emote.Controls.Add(this.icon4);
            this.Group_emote.Controls.Add(this.icon3);
            this.Group_emote.Controls.Add(this.icon2);
            this.Group_emote.Controls.Add(this.icon1);
            this.Group_emote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Group_emote.Location = new System.Drawing.Point(428, 192);
            this.Group_emote.Name = "Group_emote";
            this.Group_emote.Size = new System.Drawing.Size(200, 100);
            this.Group_emote.TabIndex = 2;
            this.Group_emote.TabStop = false;
            this.Group_emote.Text = "Cảm xúc";
            this.Group_emote.Visible = false;
            // 
            // icon6
            // 
            this.icon6.Image = ((System.Drawing.Image)(resources.GetObject("icon6.Image")));
            this.icon6.Location = new System.Drawing.Point(129, 59);
            this.icon6.Name = "icon6";
            this.icon6.Size = new System.Drawing.Size(35, 35);
            this.icon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon6.TabIndex = 8;
            this.icon6.TabStop = false;
            this.icon6.Click += new System.EventHandler(this.icon6_Click);
            // 
            // icon5
            // 
            this.icon5.Image = ((System.Drawing.Image)(resources.GetObject("icon5.Image")));
            this.icon5.Location = new System.Drawing.Point(80, 59);
            this.icon5.Name = "icon5";
            this.icon5.Size = new System.Drawing.Size(35, 35);
            this.icon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon5.TabIndex = 7;
            this.icon5.TabStop = false;
            this.icon5.Click += new System.EventHandler(this.icon5_Click);
            // 
            // icon4
            // 
            this.icon4.Image = ((System.Drawing.Image)(resources.GetObject("icon4.Image")));
            this.icon4.Location = new System.Drawing.Point(33, 59);
            this.icon4.Name = "icon4";
            this.icon4.Size = new System.Drawing.Size(35, 35);
            this.icon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon4.TabIndex = 6;
            this.icon4.TabStop = false;
            this.icon4.Click += new System.EventHandler(this.icon4_Click);
            // 
            // icon3
            // 
            this.icon3.Image = ((System.Drawing.Image)(resources.GetObject("icon3.Image")));
            this.icon3.Location = new System.Drawing.Point(129, 22);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(35, 31);
            this.icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon3.TabIndex = 5;
            this.icon3.TabStop = false;
            this.icon3.Click += new System.EventHandler(this.icon3_Click);
            // 
            // icon2
            // 
            this.icon2.Image = ((System.Drawing.Image)(resources.GetObject("icon2.Image")));
            this.icon2.Location = new System.Drawing.Point(80, 22);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(35, 31);
            this.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon2.TabIndex = 4;
            this.icon2.TabStop = false;
            this.icon2.Click += new System.EventHandler(this.icon2_Click);
            // 
            // icon1
            // 
            this.icon1.Image = ((System.Drawing.Image)(resources.GetObject("icon1.Image")));
            this.icon1.Location = new System.Drawing.Point(33, 22);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(35, 31);
            this.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon1.TabIndex = 3;
            this.icon1.TabStop = false;
            this.icon1.Click += new System.EventHandler(this.icon1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 287);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btn_emotes_hide
            // 
            this.btn_emotes_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emotes_hide.Location = new System.Drawing.Point(493, 299);
            this.btn_emotes_hide.Name = "btn_emotes_hide";
            this.btn_emotes_hide.Size = new System.Drawing.Size(75, 23);
            this.btn_emotes_hide.TabIndex = 5;
            this.btn_emotes_hide.Text = "Ẩn";
            this.btn_emotes_hide.UseVisualStyleBackColor = true;
            this.btn_emotes_hide.Click += new System.EventHandler(this.btn_emotes_hide_Click);
            // 
            // btn_emotes
            // 
            this.btn_emotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emotes.Location = new System.Drawing.Point(494, 299);
            this.btn_emotes.Name = "btn_emotes";
            this.btn_emotes.Size = new System.Drawing.Size(75, 23);
            this.btn_emotes.TabIndex = 3;
            this.btn_emotes.Text = "Cảm Xúc";
            this.btn_emotes.UseVisualStyleBackColor = true;
            this.btn_emotes.Click += new System.EventHandler(this.btn_emotes_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Location = new System.Drawing.Point(414, 299);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Gửi";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_inputMess
            // 
            this.txt_inputMess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inputMess.Location = new System.Drawing.Point(11, 299);
            this.txt_inputMess.Name = "txt_inputMess";
            this.txt_inputMess.Size = new System.Drawing.Size(397, 23);
            this.txt_inputMess.TabIndex = 1;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.pictureBox1);
            this.tab2.Controls.Add(this.btn_doianh);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.lbl_ThongTinName);
            this.tab2.Controls.Add(this.lbl_ThongTinIP);
            this.tab2.Controls.Add(this.lbl_ThongtinCong);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(656, 328);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Your Profile";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Location = new System.Drawing.Point(23, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_doianh
            // 
            this.btn_doianh.Location = new System.Drawing.Point(120, 299);
            this.btn_doianh.Name = "btn_doianh";
            this.btn_doianh.Size = new System.Drawing.Size(75, 23);
            this.btn_doianh.TabIndex = 8;
            this.btn_doianh.Text = "Đổi ảnh";
            this.btn_doianh.UseVisualStyleBackColor = true;
            this.btn_doianh.Click += new System.EventHandler(this.btn_doianh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name: ";
            // 
            // lbl_ThongTinName
            // 
            this.lbl_ThongTinName.AutoSize = true;
            this.lbl_ThongTinName.Location = new System.Drawing.Point(397, 168);
            this.lbl_ThongTinName.Name = "lbl_ThongTinName";
            this.lbl_ThongTinName.Size = new System.Drawing.Size(0, 15);
            this.lbl_ThongTinName.TabIndex = 3;
            // 
            // lbl_ThongTinIP
            // 
            this.lbl_ThongTinIP.AutoSize = true;
            this.lbl_ThongTinIP.Location = new System.Drawing.Point(352, 88);
            this.lbl_ThongTinIP.Name = "lbl_ThongTinIP";
            this.lbl_ThongTinIP.Size = new System.Drawing.Size(23, 15);
            this.lbl_ThongTinIP.TabIndex = 2;
            this.lbl_ThongTinIP.Text = "IP: ";
            // 
            // lbl_ThongtinCong
            // 
            this.lbl_ThongtinCong.AutoSize = true;
            this.lbl_ThongtinCong.Location = new System.Drawing.Point(352, 129);
            this.lbl_ThongtinCong.Name = "lbl_ThongtinCong";
            this.lbl_ThongtinCong.Size = new System.Drawing.Size(42, 15);
            this.lbl_ThongtinCong.TabIndex = 1;
            this.lbl_ThongtinCong.Text = "Cổng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Của Bạn";
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.list_all);
            this.tab3.Location = new System.Drawing.Point(4, 24);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(656, 328);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Trực tuyến";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // list_all
            // 
            this.list_all.FormattingEnabled = true;
            this.list_all.ItemHeight = 15;
            this.list_all.Location = new System.Drawing.Point(19, 18);
            this.list_all.Name = "list_all";
            this.list_all.Size = new System.Drawing.Size(212, 289);
            this.list_all.TabIndex = 0;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(680, 335);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 23);
            this.btn_file.TabIndex = 5;
            this.btn_file.Text = "File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // Server
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(764, 373);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.tabControl1);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Group_emote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_inputMess;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label lbl_ThongTinName;
        private System.Windows.Forms.Label lbl_ThongTinIP;
        private System.Windows.Forms.Label lbl_ThongtinCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.ColumnHeader cloum1;
        private Button btn_emotes;
        private GroupBox Group_emote;
        private PictureBox icon6;
        private PictureBox icon5;
        private PictureBox icon4;
        private PictureBox icon3;
        private PictureBox icon2;
        private PictureBox icon1;
        private Button btn_emotes_hide;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox list_all;
        private Button btn_image;
        private Label label2;
        private Button btn_file;
        private Button btn_doianh;
        private PictureBox pictureBox1;
    }
}