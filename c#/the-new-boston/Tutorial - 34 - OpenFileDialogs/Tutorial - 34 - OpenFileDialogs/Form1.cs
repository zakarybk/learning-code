using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___34___OpenFileDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // user browse and open files
            //ofd.Filter = "PNG Image|*.png";
            ofd.Title = "Open Filezzzz";
            ofd.Filter = "PNG Image|*.png|Text Files|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(ofd.FileName); // File path
                MessageBox.Show(ofd.SafeFileName);  // Only name
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
