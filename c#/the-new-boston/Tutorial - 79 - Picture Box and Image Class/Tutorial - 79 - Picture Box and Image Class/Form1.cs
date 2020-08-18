using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// arrow on picutre box -> size mode
// dotted line means it will be invisible
// property border single
namespace Tutorial___79___Picture_Box_and_Image_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // can also sue image class, only use Image class if setting multiple to same image, or saving for later use
                //Image image = Image.FromFile(ofd.FileName);
                //pictureBox1.ImageLocation = ofd.FileName; // path to image

                // Can also get image from url
                pictureBox1.ImageLocation = "http://combiboilersleeds.com/images/image/image-7.jpg";

            }

        }
    }
}
