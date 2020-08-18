using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___51___Remove_and_Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sentance = "Hello, my name is Adam.";
            //string after = sentance.Remove(0, 7); // removes from left, similar to substring
            //MessageBox.Show(after);

            string sentance = "Hello, my name is Adam.";
            //string after = sentance.Replace('a', '0');
            // Replaces all instances
            string after = sentance.Replace("Hello", "Hi"); // string uses "", character uses ''
            MessageBox.Show(after);


        }
    }
}
