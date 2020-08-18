using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Project -> add windows form -> user control
// build to create it
namespace Tutorial___133___Making_Controls_pt_1
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }
        string text = "";
        Color myButtonColor;
        protected override void OnPaint(PaintEventArgs e) // tab to make it
        {
            DrawButton(myButtonColor);
        }

        public string ButtonText
        {
            get { return text; }
            set { text = value; }
        }

        private void MyButton_MouseHover(object sender, EventArgs e)
        {
            // Make the colour more blue
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }
        // Public class for button colour
        public Color ButtonColor
        {
            get { return myButtonColor; }
            set
            {
                myButtonColor = value;
                try
                {
                    DrawButton(myButtonColor);
                }
                catch
                {
                    myButtonColor = Color.FromKnownColor(KnownColor.Control);
                    MessageBox.Show("Please select a valid colour!");
                }
            }
        }
        // methods are default private
        void DrawButton(Color c)
        {
            SolidBrush s = new SolidBrush(c); // button colour
            Graphics g = this.CreateGraphics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            //s.Color = Color.FromKnownColor(KnownColor.ControlLight); // combines the two colours so it's darker on the bottom still
            s.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13); // makes the colour darker
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            PointF fpoint = new Point((this.Width / 2) - (text.Length), (this.Height / 2) - (text.Length)); // float point
            FontFamily ff = new FontFamily("Arial");
            Font f = new Font(ff, 8);
            s.Color = Color.Black;
            g.DrawString(text, f, s, fpoint);
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            DrawButton(myButtonColor);
        }

        private void MyButton_MouseEnter(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }

        private void MyButton_MouseDown(object sender, MouseEventArgs e)
        {
            // Yellow
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R + 15, Color.FromKnownColor(KnownColor.Control).R - 15, 150);
            DrawButton(myColor);
        }
    }
}
