using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___120___Drawing_More_Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Bisque);
            Graphics g = panel1.CreateGraphics();
            //g.FillPie(sb, 20, 20, 60, 60, 0, 270);
            Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            g.FillPolygon(sb, points);
        }
    }
}
