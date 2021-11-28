
namespace ChatTCP
{
    partial class Form1_start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_start));
            this.lbl_IpStart = new System.Windows.Forms.Label();
            this.lbl_portStart = new System.Windows.Forms.Label();
            this.txtb_ipStart = new System.Windows.Forms.TextBox();
            this.txtb_portStart = new System.Windows.Forms.TextBox();
            this.lbl_welCome = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_cancel_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_name_start = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_newchat = new System.Windows.Forms.Button();
            this.btn_Joinchat = new System.Windows.Forms.Button();
            this.lbl_nameHost = new System.Windows.Forms.Label();
            this.lbl_portHost = new System.Windows.Forms.Label();
            this.lbl_ipHost = new System.Windows.Forms.Label();
            this.txt_nameHost = new System.Windows.Forms.TextBox();
            this.txt_portHost = new System.Windows.Forms.TextBox();
            this.txt_ipHost = new System.Windows.Forms.TextBox();
            this.btn_cancelHost = new System.Windows.Forms.Button();
            this.btn_connectHost = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_img_user = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IpStart
            // 
            this.lbl_IpStart.AutoSize = true;
            this.lbl_IpStart.Location = new System.Drawing.Point(40, 90);
            this.lbl_IpStart.Name = "lbl_IpStart";
            this.lbl_IpStart.Size = new System.Drawing.Size(42, 13);
            this.lbl_IpStart.TabIndex = 0;
            this.lbl_IpStart.Text = "IP Host";
            // 
            // lbl_portStart
            // 
            this.lbl_portStart.AutoSize = true;
            this.lbl_portStart.Location = new System.Drawing.Point(40, 120);
            this.lbl_portStart.Name = "lbl_portStart";
            this.lbl_portStart.Size = new System.Drawing.Size(26, 13);
            this.lbl_portStart.TabIndex = 1;
            this.lbl_portStart.Text = "Port";
            // 
            // txtb_ipStart
            // 
            this.txtb_ipStart.Location = new System.Drawing.Point(82, 88);
            this.txtb_ipStart.Name = "txtb_ipStart";
            this.txtb_ipStart.Size = new System.Drawing.Size(86, 20);
            this.txtb_ipStart.TabIndex = 2;
            // 
            // txtb_portStart
            // 
            this.txtb_portStart.Location = new System.Drawing.Point(82, 118);
            this.txtb_portStart.Name = "txtb_portStart";
            this.txtb_portStart.Size = new System.Drawing.Size(86, 20);
            this.txtb_portStart.TabIndex = 3;
            // 
            // lbl_welCome
            // 
            this.lbl_welCome.AutoSize = true;
            this.lbl_welCome.Font = new System.Drawing.Font("Segoe Script", 15F);
            this.lbl_welCome.ForeColor = System.Drawing.Color.Orange;
            this.lbl_welCome.Location = new System.Drawing.Point(51, 16);
            this.lbl_welCome.Name = "lbl_welCome";
            this.lbl_welCome.Size = new System.Drawing.Size(124, 32);
            this.lbl_welCome.TabIndex = 4;
            this.lbl_welCome.Text = "Well Come";
            this.lbl_welCome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(51, 144);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(46, 20);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_cancel_Start
            // 
            this.btn_cancel_Start.Location = new System.Drawing.Point(112, 144);
            this.btn_cancel_Start.Name = "btn_cancel_Start";
            this.btn_cancel_Start.Size = new System.Drawing.Size(50, 20);
            this.btn_cancel_Start.TabIndex = 6;
            this.btn_cancel_Start.Text = "Cancel";
            this.btn_cancel_Start.UseVisualStyleBackColor = true;
            this.btn_cancel_Start.Click += new System.EventHandler(this.btn_cancel_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txtb_name_start
            // 
            this.txtb_name_start.Location = new System.Drawing.Point(82, 55);
            this.txtb_name_start.Name = "txtb_name_start";
            this.txtb_name_start.Size = new System.Drawing.Size(86, 20);
            this.txtb_name_start.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(198, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_newchat
            // 
            this.btn_newchat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_newchat.FlatAppearance.BorderSize = 0;
            this.btn_newchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newchat.ForeColor = System.Drawing.Color.Black;
            this.btn_newchat.Location = new System.Drawing.Point(49, 49);
            this.btn_newchat.Name = "btn_newchat";
            this.btn_newchat.Size = new System.Drawing.Size(129, 35);
            this.btn_newchat.TabIndex = 10;
            this.btn_newchat.Text = "Tạo Phòng Mới";
            this.btn_newchat.UseVisualStyleBackColor = false;
            this.btn_newchat.Click += new System.EventHandler(this.btn_newchat_Click);
            // 
            // btn_Joinchat
            // 
            this.btn_Joinchat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Joinchat.FlatAppearance.BorderSize = 0;
            this.btn_Joinchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Joinchat.ForeColor = System.Drawing.Color.Black;
            this.btn_Joinchat.Location = new System.Drawing.Point(49, 106);
            this.btn_Joinchat.Name = "btn_Joinchat";
            this.btn_Joinchat.Size = new System.Drawing.Size(129, 35);
            this.btn_Joinchat.TabIndex = 11;
            this.btn_Joinchat.Text = "Tham Gia Chat";
            this.btn_Joinchat.UseVisualStyleBackColor = false;
            this.btn_Joinchat.Click += new System.EventHandler(this.btn_Joinchat_Click);
            // 
            // lbl_nameHost
            // 
            this.lbl_nameHost.AutoSize = true;
            this.lbl_nameHost.Location = new System.Drawing.Point(29, 60);
            this.lbl_nameHost.Name = "lbl_nameHost";
            this.lbl_nameHost.Size = new System.Drawing.Size(60, 13);
            this.lbl_nameHost.TabIndex = 12;
            this.lbl_nameHost.Text = "Name Host";
            // 
            // lbl_portHost
            // 
            this.lbl_portHost.AutoSize = true;
            this.lbl_portHost.Location = new System.Drawing.Point(29, 91);
            this.lbl_portHost.Name = "lbl_portHost";
            this.lbl_portHost.Size = new System.Drawing.Size(26, 13);
            this.lbl_portHost.TabIndex = 13;
            this.lbl_portHost.Text = "Port";
            // 
            // lbl_ipHost
            // 
            this.lbl_ipHost.AutoSize = true;
            this.lbl_ipHost.Location = new System.Drawing.Point(29, 121);
            this.lbl_ipHost.Name = "lbl_ipHost";
            this.lbl_ipHost.Size = new System.Drawing.Size(17, 13);
            this.lbl_ipHost.TabIndex = 14;
            this.lbl_ipHost.Text = "IP";
            // 
            // txt_nameHost
            // 
            this.txt_nameHost.Location = new System.Drawing.Point(92, 53);
            this.txt_nameHost.Name = "txt_nameHost";
            this.txt_nameHost.Size = new System.Drawing.Size(86, 20);
            this.txt_nameHost.TabIndex = 15;
            // 
            // txt_portHost
            // 
            this.txt_portHost.Location = new System.Drawing.Point(92, 84);
            this.txt_portHost.Name = "txt_portHost";
            this.txt_portHost.Size = new System.Drawing.Size(86, 20);
            this.txt_portHost.TabIndex = 16;
            // 
            // txt_ipHost
            // 
            this.txt_ipHost.Location = new System.Drawing.Point(92, 114);
            this.txt_ipHost.Name = "txt_ipHost";
            this.txt_ipHost.Size = new System.Drawing.Size(86, 20);
            this.txt_ipHost.TabIndex = 17;
            // 
            // btn_cancelHost
            // 
            this.btn_cancelHost.Location = new System.Drawing.Point(113, 150);
            this.btn_cancelHost.Name = "btn_cancelHost";
            this.btn_cancelHost.Size = new System.Drawing.Size(64, 20);
            this.btn_cancelHost.TabIndex = 18;
            this.btn_cancelHost.Text = "Cancel";
            this.btn_cancelHost.UseVisualStyleBackColor = true;
            this.btn_cancelHost.Click += new System.EventHandler(this.btn_cancelHost_Click);
            // 
            // btn_connectHost
            // 
            this.btn_connectHost.Location = new System.Drawing.Point(29, 150);
            this.btn_connectHost.Name = "btn_connectHost";
            this.btn_connectHost.Size = new System.Drawing.Size(64, 20);
            this.btn_connectHost.TabIndex = 19;
            this.btn_connectHost.Text = "Start";
            this.btn_connectHost.UseVisualStyleBackColor = true;
            this.btn_connectHost.Click += new System.EventHandler(this.btn_connectHost_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(285, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btn_img_user
            // 
            this.btn_img_user.Location = new System.Drawing.Point(344, 168);
            this.btn_img_user.Name = "btn_img_user";
            this.btn_img_user.Size = new System.Drawing.Size(64, 20);
            this.btn_img_user.TabIndex = 21;
            this.btn_img_user.Text = "Sửa ảnh";
            this.btn_img_user.UseVisualStyleBackColor = true;
            this.btn_img_user.Click += new System.EventHandler(this.btn_img_user_Click);
            // 
            // Form1_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 198);
            this.Controls.Add(this.btn_img_user);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_connectHost);
            this.Controls.Add(this.btn_cancelHost);
            this.Controls.Add(this.txt_ipHost);
            this.Controls.Add(this.txt_portHost);
            this.Controls.Add(this.txt_nameHost);
            this.Controls.Add(this.lbl_ipHost);
            this.Controls.Add(this.lbl_portHost);
            this.Controls.Add(this.lbl_nameHost);
            this.Controls.Add(this.btn_Joinchat);
            this.Controls.Add(this.btn_newchat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtb_name_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel_Start);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_welCome);
            this.Controls.Add(this.txtb_portStart);
            this.Controls.Add(this.txtb_ipStart);
            this.Controls.Add(this.lbl_portStart);
            this.Controls.Add(this.lbl_IpStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "Form1_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Room VKU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_start_FormClosed);
            this.Load += new System.EventHandler(this.Form1_start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IpStart;
        private System.Windows.Forms.Label lbl_portStart;
        private System.Windows.Forms.TextBox txtb_ipStart;
        private System.Windows.Forms.TextBox txtb_portStart;
        private System.Windows.Forms.Label lbl_welCome;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_cancel_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_name_start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newchat;
        private System.Windows.Forms.Button btn_Joinchat;
        private System.Windows.Forms.Label lbl_nameHost;
        private System.Windows.Forms.Label lbl_portHost;
        private System.Windows.Forms.Label lbl_ipHost;
        private System.Windows.Forms.TextBox txt_nameHost;
        private System.Windows.Forms.TextBox txt_portHost;
        private System.Windows.Forms.TextBox txt_ipHost;
        private System.Windows.Forms.Button btn_cancelHost;
        private System.Windows.Forms.Button btn_connectHost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_img_user;
    }
}