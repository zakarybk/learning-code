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

namespace Tutorial___69___Threading_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t; // Initalise it so that we can use it in FormClosing
        private void button1_Click(object sender, EventArgs e)
        {
            // Stops the application from freezeing from the infinite for loop!
            t = new Thread(Freeze); // Thread the freeze method
            t.Start(); // Invokes the thread/method
            // Cannot exit out of the application as thread is still running
            
        }
        // using System.Threading;
        void Freeze()
        {
            for (; ; ) ; // Will continue forever so freeze application
        }

        // Lighting property on frame 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort(); // End the thread so we can close application
        }
    }
}
