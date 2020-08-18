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

namespace Tutorial___42___BinaryReader_pt_2
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
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            //br.BaseStream.Position = 0x10;
            byte[] buffer = br.ReadBytes(2); // Int16 is 2 bytes, Int32 is 4 bytes
            // Reverse byte array to read the bytes in the right order (for humans)
            Array.Reverse(buffer);
            textBox1.Text = BitConverter.ToInt16(buffer, 0).ToString("X"); // convert bytes into int16(short) then to hexdecimal string
            br.Dispose();
        }
    }
}
