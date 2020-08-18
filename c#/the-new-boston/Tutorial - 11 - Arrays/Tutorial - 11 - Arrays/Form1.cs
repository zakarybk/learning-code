using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___11___Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] Names = { "Bob", "Steve", "Adam" };
            //string[] Names = new string[5];
            //Names[0] = "Bob";

            //MessageBox.Show(Names[4]);

            int[] Numbers = { 1, 2, 3 };
            MessageBox.Show(Numbers[0].ToString());
        }
    }
}
