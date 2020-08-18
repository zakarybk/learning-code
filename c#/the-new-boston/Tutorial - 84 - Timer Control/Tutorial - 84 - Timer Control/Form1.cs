using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Using timer, timer property drags in from left but doesn't appear on the menu
namespace Tutorial___84___Timer_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //// Only allow it to tick ones
            //timer1.Stop();
            //// We'll get this after one second, interval is one second
            //MessageBox.Show("Hello");
            i++;
            textBox1.Text = i.ToString();
        }
    }
}
