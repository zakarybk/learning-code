using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutorial___43___BinaryWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Binary writier writes like it reads, left to right
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
            //short myShort = 1;
            int myShort = 0x6567;
            // Converts short into byte array
            byte[] buffer = BitConverter.GetBytes(myShort);
            Array.Reverse(buffer);
            //bw.Write('C');
            bw.Write(buffer);
            bw.Dispose();
        }
    }
}
