using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___49___Substrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = "John Smith";
            string FirstName = Name.Substring(0, 4);
            string LastName = Name.Substring(5, 5); // if reading to the end, don't need last number
            MessageBox.Show(LastName);
        }
    }
}
