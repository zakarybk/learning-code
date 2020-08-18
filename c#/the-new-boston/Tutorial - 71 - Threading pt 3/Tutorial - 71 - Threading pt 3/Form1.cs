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

namespace Tutorial___71___Threading_pt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;
        string myString; 
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(Write);
            object[] objA = { "Bob", 500 };
            //t.Start("Adam");
            t.Start(objA);
            t.Join();
            textBox1.Text = myString;
        }
        //void Write(object myObject) // Can only pass objects through Thread. ONLY ONE OBJECT!!! :'(
        //{
        //    for (int i = 0; i < 1000; i++)
        //        myString += myObject.ToString() + i.ToString() + "\r\n";
        //}
        void Write(object array) // Can only pass objects through Thread. ONLY ONE OBJECT!!! :'(
        {
            object[] o = array as object[];
            for (int i = 0; i < Convert.ToUInt32(o[1]); i++)
            {
                Thread.Sleep(1); // how many miliseconds to sleep for 1 = 0.001 seconds
                myString += o[0].ToString() + i.ToString() + "\r\n";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
