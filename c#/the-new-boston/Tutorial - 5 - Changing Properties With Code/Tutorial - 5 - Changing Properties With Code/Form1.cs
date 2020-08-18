using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___5___Changing_Properties_With_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = "Bob";
            //button1.Enabled = false;
            //button1.Height = 60;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Bob";
        }
    }
}
