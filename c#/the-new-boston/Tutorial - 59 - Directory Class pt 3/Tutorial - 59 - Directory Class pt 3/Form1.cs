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

namespace Tutorial___59___Directory_Class_pt_3
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
                //Directory.CreateDirectory(fbd.SelectedPath + "\\Bob"); // have to add two backslah, one \ means ignore quote
                //Directory.Move(fbd.SelectedPath, "C:\\Users\\Zak\\Desktop\\Bob"); // last is the name of the folder you're moving
                //Directory.Delete(fbd.SelectedPath);

            }
        }
    }
}
