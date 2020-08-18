using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tutorial___63___Process_Class_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Using System.Diagnostics
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Process.Start(ofd.FileName); // Opens executable file from ofd
                //Process.Start("notepad.exe"); // located in system32 folder so don't need path
                //MessageBox.Show(Process.GetCurrentProcess().ProcessName); // shows project and the namespace names --> Tutorial - 63 - Process Class pt 1.vshost --> can be found in taskmanager process
                Process.GetCurrentProcess().Kill(); // kills current precess

            }
        }
    }
}
