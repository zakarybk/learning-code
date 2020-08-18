using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Tutorial___126___PathGradientBrush_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(20, 20, 50, 50); // starts at center, moves out and changes colour
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.Red;
            pgb.SurroundColors = new Color[] { Color.Yellow };
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(pgb, 20, 20, 50, 50); // use out brush so we get the effect
        }
    }
}
