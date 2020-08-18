using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tutorial___167___IEnumerable_and_Yield_Return
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        IEnumerable GetNumbers(int min, int max)
        {
            // already have int, so can just use ;
            for (; min <= max; min++)
                yield return min; // yeild, only when we need them so GetNumbers(0, 5) will do nothing (allows us to use stuff in this collection when we need it)
            // foreach (int i in GetNumbers(0,10)) MessageBox.Show(i.ToString()) will work
        }
    }
}
