using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___45___Convert_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Also others like tobool etc -- turn string into the type if it is the right type otherwise error
            // Possibly add try/catch to these
            try
            {
                int myInt = Convert.ToInt32(textBox1.Text) + 2;
                MessageBox.Show(myInt.ToString());
            }
            catch { MessageBox.Show("That wasn't an interger!"); }
        }
    }
}
