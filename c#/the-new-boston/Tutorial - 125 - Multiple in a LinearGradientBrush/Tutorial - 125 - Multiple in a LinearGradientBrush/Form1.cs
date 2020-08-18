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
//using System.Drawing.Drawing2D;
namespace Tutorial___125___Multiple_in_a_LinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Black, Color.Red);
            Graphics g = panel1.CreateGraphics();
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.Black, Color.Blue, Color.SkyBlue, Color.White }; // can be any number
            cb.Positions = new float[] { 0, .33F, .66F, 1F }; // f for decimal float, same distance to make it smooth, always end on 1
            lgb.InterpolationColors = cb; // put different colours
            g.FillRectangle(lgb, 20, 20, 50, 50);
        }
    }
}
