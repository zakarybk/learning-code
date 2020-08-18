using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_4_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string name = "Adam";
            // int number = 5; number.ToString()
            // bool redHair = false;
            object myObject = true; // can hold any value
            MessageBox.Show(myObject.ToString());
        }
    }
}
