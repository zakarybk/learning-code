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

namespace Tutorial___41___BinaryReader_pt_1
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

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
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            //br.BaseStream.Position = 0x10; // sets the read position, needs to be hex
            //textBox1.Text = br.ReadChar().ToString(); // Reads the first letter, char needs to be turned into a string
            // Now for a string
            //foreach (char myChar in br.ReadChars(4)) textBox1.Text += myChar;
            // Now for int, it reads back to front... 00 01 --> 100
            textBox1.Text = br.ReadInt16().ToString("X"); // 16 bit interget = 2 bytes
            br.Dispose();
        }
    }
}
