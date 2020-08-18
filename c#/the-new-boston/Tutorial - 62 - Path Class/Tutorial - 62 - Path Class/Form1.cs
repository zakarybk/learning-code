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

namespace Tutorial___62___Path_Class
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
            if (ofd.ShowDialog() == DialogResult.OK)
                //MessageBox.Show(Path.GetDirectoryName(ofd.FileName).ToString());
                //MessageBox.Show(Path.GetExtension(ofd.FileName).ToString());
                //MessageBox.Show(Path.GetFileName(ofd.FileName).ToString()); // returns the name without path
                //MessageBox.Show(Path.GetFileNameWithoutExtension(ofd.FileName).ToString()); // File name without extension
                //MessageBox.Show(Path.GetFullPath(ofd.FileName).ToString()); // same apth as ofd.FileName
                MessageBox.Show(Path.HasExtension(ofd.FileName).ToString());

        }
    }
}
