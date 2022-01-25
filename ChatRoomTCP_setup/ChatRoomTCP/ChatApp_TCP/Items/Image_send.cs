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
    public partial class Image_send : UserControl
    {
        public Image_send()
        {
            InitializeComponent();
            pictureBox_image_send.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Image Image
        {
            get => pictureBox_image_send.Image; set => pictureBox_image_send.Image = value;
        }

        public int size_width
        {
            get
            {
                return this.Width;
            }
            set
            {
                pictureBox_image_send.Width = value;
            }
        }
        public int size_height
        {
            get
            {
                return this.Height;
            }
            set
            {
                pictureBox_image_send.Height = value;
            }
        }
    }
}
