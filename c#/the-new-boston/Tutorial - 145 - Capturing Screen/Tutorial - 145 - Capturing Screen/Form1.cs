using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tutorial___145___Capturing_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// bitmap! -- for image!
            //Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height); // primary screen is one with task bar, working area is everything on your screen
            //Graphics g = Graphics.FromImage(b);
            //g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size); // point in bitmap to start copying
            //// Set our picture box to the image we just captured!
            //pictureBox1.Image = b;
            Thread t = new Thread(Blah); // thread so our app doesn't freeze
            t.Start();
        }
        void Blah()
        {
            // bitmap!
            for (;;) // ;; = infin
            {
                Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height); // primary screen is one with task bar, working area is everything on your screen
                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size); // point in bitmap to start copying
                                                                                                   // Set our picture box to the image we just captured!
                pictureBox1.Image = b;
            }
        }
    }
}
