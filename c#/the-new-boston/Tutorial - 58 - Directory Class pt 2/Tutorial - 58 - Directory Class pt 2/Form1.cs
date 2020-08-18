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

namespace Tutorial___58___Directory_Class_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(Directory.GetCreationTime(fbd.SelectedPath).ToString());
                //MessageBox.Show(Directory.GetLastAccessTime(fbd.SelectedPath).ToString());
                //MessageBox.Show(Directory.GetLastWriteTime(fbd.SelectedPath).ToString());
                MessageBox.Show(Directory.GetParent(fbd.SelectedPath).ToString());

            }
        }
    }
}
