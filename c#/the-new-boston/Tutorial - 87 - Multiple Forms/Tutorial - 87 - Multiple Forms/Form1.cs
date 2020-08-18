using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// project _> add windows form
namespace Tutorial___87___Multiple_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(textBox1.Text); // give the new form our text
            //f.Show(); // show 2nd form on button click
            f.ShowDialog(); // Disables old one whilst new one is open!
        }
    }
}
