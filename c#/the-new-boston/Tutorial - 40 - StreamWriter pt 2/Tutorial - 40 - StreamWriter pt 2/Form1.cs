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

namespace Tutorial___40___StreamWriter_pt_2
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

                ofd.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.BaseStream.Position = 0x2B;
            //sw.BaseStream.WriteByte(0x00);  // Writes 0x00 at pos 0
            //sw.BaseStream.WriteByte(0xFF); // max hex value
            byte[] buffer = { 0x08, 0x09, 0x0A };
            sw.BaseStream.Write(buffer, 0, 3); // write 0, 3 from byte array
            sw.Dispose();
        }
    }
}
