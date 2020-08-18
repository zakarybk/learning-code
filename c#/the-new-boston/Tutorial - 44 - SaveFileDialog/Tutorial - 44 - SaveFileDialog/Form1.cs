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

namespace Tutorial___44___SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text|*.txt";
            sfd.FileName = "Bob"; // don't need to type extension because of filter
            sfd.Title = "Something!";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                BinaryWriter br = new BinaryWriter(File.Create(path));
                br.Write("Text text text");
                br.Dispose();
            }
        }
    }
}
