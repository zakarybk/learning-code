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

namespace Tutorial___60___File_Class_pt_1
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
                //MessageBox.Show(File.Exists(ofd.FileName).ToString());
                MessageBox.Show(File.Exists("C:\\Users\\Zak\\Documents\\hello.txt").ToString()); // this is how it would be used because ofd wouldn't give invalid file
                //File.Delete(ofd.FileName); // deletes any file you open

        }
    }
}
