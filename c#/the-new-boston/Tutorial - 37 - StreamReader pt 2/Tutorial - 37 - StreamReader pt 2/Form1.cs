using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// IO
using System.IO;

namespace Tutorial___37___StreamReader_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                sr.BaseStream.Position = 0x0C; // Where to start at, use hxd to find it easily, 0x to represent hex in C#
                //textBox1.Text = sr.BaseStream.ReadByte().ToString("X"); // show in hexidecimal, only reads first
                byte[] buffer = new byte[3]; // Byte arrays are normally called buffers, in this context at least
                sr.BaseStream.Read(buffer, 0, 3); // buffer should now hold the first 3 bytes from the file
                foreach (byte myBytes in buffer)
                    textBox1.Text += myBytes.ToString("X") + " "; // X for hexidecimal, also add space to tell them apart
                sr.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
