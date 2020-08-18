using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___50___IndexOf_and_Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = "John Smith";
            //string Firstname = name.Substring(0, name.IndexOf(' '));
            //string Lastname = name.Substring(name.IndexOf(' ')+1); // +1 to remove space // Don't need 2nd arg on last string
            string name = "   John Smith  ";
            string rawName = name.Trim(); // TrimStart to just strim the start, also TrimEnd
            MessageBox.Show(rawName);
        }
    }
}
