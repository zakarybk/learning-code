using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___14___Do_and_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int i = 0;
            while (i < 10)
            {
                textBox1.Text += i.ToString();
                i++;
                
            }
            */
            int i = 0;
            do // will go at least once
            {
                textBox1.Text += i.ToString();
            }
            while (i < 10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
