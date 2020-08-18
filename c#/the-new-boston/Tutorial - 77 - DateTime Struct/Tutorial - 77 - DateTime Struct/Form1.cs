using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___77___DateTime_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime dt = new DateTime(1995, 10, 16, 3, 32, 52);
            //DateTime dt = DateTime.Today;
            //DateTime dt = DateTime.Now;
            //MessageBox.Show(dt.ToString());
            //MessageBox.Show(DateTime.IsLeapYear(2012).ToString());
            //MessageBox.Show(DateTime.DaysInMonth(2011, 7).ToString());
            //MessageBox.Show(DateTime.Now.ToFileTime().ToString()); // for use in files, returns long
            MessageBox.Show(DateTime.FromFileTime(DateTime.Now.ToFileTime()).ToString()); // from file time to normal

        }
    }
}
