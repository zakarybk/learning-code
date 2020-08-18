using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___123___Drawing_Strings_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush s = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");
            Font font = new Font(ff, 10, FontStyle.Bold); // font created, so we do't edit other fonts
            g.DrawString("Adam", font, s, new Point(20, 20));
        }
    }
}
