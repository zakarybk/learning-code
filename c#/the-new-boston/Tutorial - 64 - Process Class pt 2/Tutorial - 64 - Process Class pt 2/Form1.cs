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

namespace Tutorial___64___Process_Class_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Process p in Process.GetProcesses())
            //    MessageBox.Show(p.ProcessName);
            //p.Responding() // tells you if the process is responding, useful for crashes
            //if (!p.Responding()) p.Kill(); // kills any processes which aren't responding
            
            foreach (Process p in Process.GetProcessesByName("chrome")) // Shows you all chrome processes
                MessageBox.Show(p.ProcessName);

        }
    }
}
