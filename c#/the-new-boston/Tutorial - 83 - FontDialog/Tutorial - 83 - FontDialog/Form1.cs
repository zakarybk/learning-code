using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___83___FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            //fd.MaxSize = 32; // set max/min size
            fd.ShowColor = true; // let them set the colour
            fd.ShowHelp = true;
            fd.HelpRequest += Fd_HelpRequest;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
                textBox1.ForeColor = fd.Color;
            }

        }

        private void Fd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Noob!");
        }
    }
}
