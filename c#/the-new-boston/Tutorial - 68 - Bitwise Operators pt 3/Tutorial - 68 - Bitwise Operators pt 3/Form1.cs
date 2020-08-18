using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___68___Bitwise_Operators_pt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //short myShort = 3 ^ 5; // 011 ^ 101 = 110 // both need to be different for 1
            //short myShort = 3 ^ 4; // 011 ^ 100 = 111
            //short myShort = 3 >> 1; // shifts bits one to the right // 11 >> 1
            //short myShort = 5 >> 1; // 101 >> 10
            //short myShort = 3 << 1; // 11 << 110 // shifts to the left
            //short myShort = 5 << 1; // 101 << 1010
            MessageBox.Show(Convert.ToString(myShort, 2));


        }
    }
}
