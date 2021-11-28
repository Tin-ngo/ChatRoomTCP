
namespace ChatTCP
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btn_img_user_client = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ThongTinName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ThongTinIP = new System.Windows.Forms.Label();
            this.lbl_ThongtinCong = new System.Windows.Forms.Label();
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
            this.btn_emotes = new System.Windows.Forms.Button();
            this.btn_emotes_hide = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_inputMess_client = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab1.SuspendLayout();
            this.Group_emote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btn_img_user_client);
            this.tab2.Controls.Add(this.pictureBox1);
            this.tab2.Controls.Add(this.lbl_ThongTinName);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Controls.Add(this.lbl_ThongTinIP);
            this.tab2.Controls.Add(this.lbl_ThongtinCong);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(651, 355);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Your Profile";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btn_img_user_client
            // 
            this.btn_img_user_client.Location = new System.Drawing.Point(128, 326);
            this.btn_img_user_client.Name = "btn_img_user_client";
            this.btn_img_user_client.Size = new System.Drawing.Size(75, 23);
            this.btn_img_user_client.TabIndex = 11;
            this.btn_img_user_client.Text = "Đổi ảnh";
            this.btn_img_user_client.UseVisualStyleBackColor = true;
            this.btn_img_user_client.Click += new System.EventHandler(this.btn_img_user_client_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ThongTinName
            // 
            this.lbl_ThongTinName.AutoSize = true;
            this.lbl_ThongTinName.Location = new System.Drawing.Point(369, 178);
            this.lbl_ThongTinName.Name = "lbl_ThongTinName";
            this.lbl_ThongTinName.Size = new System.Drawing.Size(45, 15);
            this.lbl_ThongTinName.TabIndex = 9;
            this.lbl_ThongTinName.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông Tin Của Bạn";
            // 
            // lbl_ThongTinIP
            // 
            this.lbl_ThongTinIP.AutoSize = true;
            this.lbl_ThongTinIP.Location = new System.Drawing.Point(369, 98);
            this.lbl_ThongTinIP.Name = "lbl_ThongTinIP";
            this.lbl_ThongTinIP.Size = new System.Drawing.Size(23, 15);
            this.lbl_ThongTinIP.TabIndex = 8;
            this.lbl_ThongTinIP.Text = "IP: ";
            // 
            // lbl_ThongtinCong
            // 
            this.lbl_ThongtinCong.AutoSize = true;
            this.lbl_ThongtinCong.Location = new System.Drawing.Point(369, 139);
            this.lbl_ThongtinCong.Name = "lbl_ThongtinCong";
            this.lbl_ThongtinCong.Size = new System.Drawing.Size(42, 15);
            this.lbl_ThongtinCong.TabIndex = 7;
            this.lbl_ThongtinCong.Text = "Cổng: ";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_image);
            this.tab1.Controls.Add(this.Group_emote);
            this.tab1.Controls.Add(this.flowLayoutPanel1);
            this.tab1.Controls.Add(this.btn_emotes);
            this.tab1.Controls.Add(this.btn_emotes_hide);
            this.tab1.Controls.Add(this.btn_Send);
            this.tab1.Controls.Add(this.txt_inputMess_client);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(651, 355);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Message";
            this.tab1.UseVisualStyleBackColor = true;
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(572, 328);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(75, 23);
            this.btn_image.TabIndex = 11;
            this.btn_image.Text = "Ảnh";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // Group_emote
            // 
            this.Group_emote.Controls.Add(this.icon6);
            this.Group_emote.Controls.Add(this.icon5);
            this.Group_emote.Controls.Add(this.icon4);
            this.Group_emote.Controls.Add(this.icon3);
            this.Group_emote.Controls.Add(this.icon2);
            this.Group_emote.Controls.Add(this.icon1);
            this.Group_emote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Group_emote.Location = new System.Drawing.Point(438, 220);
            this.Group_emote.Name = "Group_emote";
            this.Group_emote.Size = new System.Drawing.Size(195, 100);
            this.Group_emote.TabIndex = 9;
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
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(641, 314);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btn_emotes
            // 
            this.btn_emotes.Location = new System.Drawing.Point(491, 329);
            this.btn_emotes.Name = "btn_emotes";
            this.btn_emotes.Size = new System.Drawing.Size(75, 23);
            this.btn_emotes.TabIndex = 8;
            this.btn_emotes.Text = "Cảm Xúc";
            this.btn_emotes.UseVisualStyleBackColor = true;
            this.btn_emotes.Click += new System.EventHandler(this.btn_emotes_Click);
            // 
            // btn_emotes_hide
            // 
            this.btn_emotes_hide.Location = new System.Drawing.Point(491, 328);
            this.btn_emotes_hide.Name = "btn_emotes_hide";
            this.btn_emotes_hide.Size = new System.Drawing.Size(75, 23);
            this.btn_emotes_hide.TabIndex = 7;
            this.btn_emotes_hide.Text = "Ẩn";
            this.btn_emotes_hide.UseVisualStyleBackColor = true;
            this.btn_emotes_hide.Click += new System.EventHandler(this.btn_emotes_hide_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(407, 328);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Gửi";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_inputMess_client
            // 
            this.txt_inputMess_client.Location = new System.Drawing.Point(6, 328);
            this.txt_inputMess_client.Name = "txt_inputMess_client";
            this.txt_inputMess_client.Size = new System.Drawing.Size(395, 23);
            this.txt_inputMess_client.TabIndex = 1;
            this.txt_inputMess_client.TextChanged += new System.EventHandler(this.txt_inputMess_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // Client
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Group_emote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_inputMess;
        private System.Windows.Forms.ListView Lv_ShowMess_Join;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.ListBox Lv_ShowMess_client;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_inputMess_client;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_emotes_hide;
        private System.Windows.Forms.Button btn_emotes;
        private System.Windows.Forms.GroupBox Group_emote;
        private System.Windows.Forms.PictureBox icon6;
        private System.Windows.Forms.PictureBox icon5;
        private System.Windows.Forms.PictureBox icon4;
        private System.Windows.Forms.PictureBox icon3;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ThongTinName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ThongTinIP;
        private System.Windows.Forms.Label lbl_ThongtinCong;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_img_user_client;
    }
}