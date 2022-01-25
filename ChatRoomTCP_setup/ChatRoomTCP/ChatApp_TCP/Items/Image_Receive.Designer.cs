
namespace ChatTCP.Items
{
    partial class Image_Receive
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
            this.pictureBox_img1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_img1
            // 
            this.pictureBox_img1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_img1.Name = "pictureBox_img1";
            this.pictureBox_img1.Size = new System.Drawing.Size(255, 250);
            this.pictureBox_img1.TabIndex = 0;
            this.pictureBox_img1.TabStop = false;
            // 
            // Image_Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_img1);
            this.Name = "Image_Receive";
            this.Size = new System.Drawing.Size(525, 274);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_img1;
    }
}