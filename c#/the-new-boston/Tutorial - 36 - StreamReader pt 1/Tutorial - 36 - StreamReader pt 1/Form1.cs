using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Use the IO namespace
using System.IO;

namespace Tutorial___36___StreamReader_pt_1
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
            ofd.Filter ="Text Files|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                textBox1.Text = sr.ReadToEnd(); // Put all text from txt file into textbox, look at hxd to see what it reads
                sr.Dispose(); // Closes the file, cannot read if it's already being read
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
