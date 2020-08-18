using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___65___Null_Coalesce_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myString = null;
            //if (myString == null)
            //    MessageBox.Show("String is null!");
            //else
            //    MessageBox.Show(myString);
            //MessageBox.Show(myString ?? "NULL!!!!"); // if myString is nul, default to pre-defined string

            int? i = null; // need ?> after int if takes null. Works for all non-nullable typs
            int x = i ?? 8; // If i is null, make it 8
            MessageBox.Show(x.ToString());

        }
    }
}
