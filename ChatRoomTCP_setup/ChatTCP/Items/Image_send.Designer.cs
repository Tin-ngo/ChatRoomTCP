
namespace ChatTCP.Items
{
    partial class Image_send
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
            this.pictureBox_image_send = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_send)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_image_send
            // 
            this.pictureBox_image_send.Location = new System.Drawing.Point(18, 18);
            this.pictureBox_image_send.Name = "pictureBox_image_send";
            this.pictureBox_image_send.Size = new System.Drawing.Size(278, 237);
            this.pictureBox_image_send.TabIndex = 0;
            this.pictureBox_image_send.TabStop = false;
            // 
            // Image_send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_image_send);
            this.Name = "Image_send";
            this.Size = new System.Drawing.Size(312, 272);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_send)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_image_send;
    }
}