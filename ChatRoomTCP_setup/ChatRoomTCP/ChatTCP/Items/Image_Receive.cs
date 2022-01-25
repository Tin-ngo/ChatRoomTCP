using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTCP.Items
{
    public partial class Image_Receive : UserControl
    {
        public Image_Receive()
        {
            InitializeComponent();
            pictureBox_img1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Image Image
        {
            get => pictureBox_img1.Image; set => pictureBox_img1.Image = value;   
        }

         public int size_width
         {
            set
            {
                pictureBox_img1.Width = value;
            }
        }

        public int size_height
        {
            set
            {
                pictureBox_img1.Height = value;
            }
        }


    }
}
