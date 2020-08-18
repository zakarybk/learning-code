using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___119___Drawing_Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics(); // allows us to paint on the panel
            g.FillRectangle(sb, 20, 20, 50, 50);
            g.FillEllipse(sb, 50, 50, 50, 50);
        }
    }
}
