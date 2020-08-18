using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tutorial_70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;
        string myString = "";
        private void button1_Click(object sender, EventArgs e)
        {
            // When a thread is started, it'll continue with the code beneath it!
            t = new Thread(Write);
            t.Start();
            // Blocks code benath from running until thread is finished
            t.Join();
            // Set the textbox 1 outside the thread we created so that we can change it
            textBox1.Text = myString;
        }
        void Write()
        {
            for (int i = 0; i < 1000; i++)
                // This errors, to do with threads
                //textBox1.Text += "Adam" + i.ToString() + "\r\n"; // adds new line
                // So we build a string instead
                myString += "Adam" + i.ToString() + "\r\n";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
