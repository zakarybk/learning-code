using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___33___Ternary_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myString = ""; // Top bar lines thingy adds comments ezz pezzz
            //if (checkBox1.Checked) myString = "It's checked!";
            //else myString = "It's not checked :(";
            //string myString = (checkBox1.Checked) ? "It's checked!" : "It's not checked :(";    //
            //MessageBox.Show(myString);
            MessageBox.Show((checkBox1.Checked) ? "It's checked!" : "It's not checked :("); // less codeszzzz
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
