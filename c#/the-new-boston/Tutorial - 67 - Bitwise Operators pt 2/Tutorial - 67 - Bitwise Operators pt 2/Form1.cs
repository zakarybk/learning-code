using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___67___Bitwise_Operators_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 011 & 101 = 001 // if both 1 then 1 else 0
            //short myShort = 3 & 5;  // && and for if statements, & to compare at bitwise level // (and)
            //short myShort = 3 & 4; // 011 & 100 = 000
            //short myShort = 3 | 4; // 011 | 100 = 111 // only one needs to be 1 for 1 // (or)
            short myShort = 3 & 5; // 011 | 101 = 111
            MessageBox.Show(Convert.ToString(myShort, 2)); 


        }
    }
}
