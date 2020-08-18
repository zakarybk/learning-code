using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___122___Drawing_With_Pen_Class_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Graphics g = panel1.CreateGraphics();
            //g.DrawArc(pen, 20, 20, 100, 100, 0, 180);
            //g.DrawBezier(pen, new Point(20, 20), new Point(30, 60), new Point(70, 40), new Point(50, 80)); // spline --> curved line
            g.DrawLine(pen, new Point(0, 0), new Point(100, 100));
        }
    }
}
