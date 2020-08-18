using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___66___Bitwise_Operators_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculator, view -> programmer
            // Short is 16 bits, so 16 numbers, so 11 would have 14 0s infront
            // 11 with 16 bits inverted would be 1111111111111100
            short myShort = ~5;  // ~ means invert (3,5 etc)
            MessageBox.Show(Convert.ToString(myShort, 2)); // Tells it that it should be in binary (1s + 0s)

        }
    }
}
