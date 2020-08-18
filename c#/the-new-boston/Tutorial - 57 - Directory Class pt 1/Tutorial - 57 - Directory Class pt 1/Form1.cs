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

namespace Tutorial___57___Directory_Class_pt_1
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
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                //string[] directories Directory.GetDirectories(fbd.SelectedPath);

                //foreach (string s in files)
                //    MessageBox.Show(s);

                //foreach (string s in directories)
                //    MessageBox.Show(s);

                string[] drives = Directory.GetLogicalDrives();
                foreach (string s in drives)
                    MessageBox.Show(s);
            }
        }
    }
}
