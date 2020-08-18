using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___121___Drawing_with_Pen_Class_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3); // pen outline, brush fills // colour, width
            Graphics g = panel1.CreateGraphics();
            //g.DrawRectangle(pen, 20, 20, 50, 50);
            //g.DrawEllipse(pen, 20, 20, 50, 50);
            Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            g.DrawPolygon(pen, points);
        }
    }
}
