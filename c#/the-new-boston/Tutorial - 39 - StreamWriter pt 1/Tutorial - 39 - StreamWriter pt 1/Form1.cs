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

namespace Tutorial___39___StreamWriter_pt_1
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.Create(path)); // File.OpenWrite(path) replaces the first letters with yours, File.Create(path) removes everything and adds your text
            sw.Write(textBox1.Text);
            // Can also use WriteLine to add lines of text, however adding write after will just go on the next line if after WriteLine. Write puts eveyrhting on the same line
            sw.Dispose(); // to stop being used by another process errors
            MessageBox.Show("Write successful", "Write Status");
        }
    }
}
