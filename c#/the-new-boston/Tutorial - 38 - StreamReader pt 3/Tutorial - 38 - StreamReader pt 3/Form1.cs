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

namespace Tutorial___38___StreamReader_pt_3
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
                // pos is 0
                // Peak doesn't change position but read does
                char c = (char)sr.Peek(); // Casting, converts into a character // similar to read, reads a character at a position
                char cr1 = (char)sr.Read();   // After read reads, pos is 1
                char cr2 = (char)sr.Read();  // Reading at position one
                MessageBox.Show(c.ToString() + " " + cr1.ToString() + " " + cr2.ToString());

                sr.Dispose();
            }
        }
    }
}
