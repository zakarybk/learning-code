using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___82___Color_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ColorDialog cd = new ColorDialog();
            //if (cd.ShowDialog() == DialogResult.OK)
            //{
            //    Color c = cd.Color; // c = picked colour
            //    //if (c.IsNamedColor) MessageBox.Show(c.Name); // If the colour has a name, show the name
            //    // KnownColor. // to see the different colours
            //    if (c.IsKnownColor) MessageBox.Show(c.ToKnownColor().ToString()); // Tells us if windows uses this colour!
            //}

            //Color c = Color.MintCream; // It's a named colour
            //MessageBox.Show(c.Name);
            Color c = Color.FromKnownColor(KnownColor.MintCream); // The known colours
            MessageBox.Show(c.ToArgb().ToString("X")); // converts colour to a 32 bit (4 byte) representation of the colour
            //MessageBox.Show(c.ToKnownColor().ToString());
            int i = c.ToArgb;
            Color b = Color.FromArgb(i);

        }
    }
}
