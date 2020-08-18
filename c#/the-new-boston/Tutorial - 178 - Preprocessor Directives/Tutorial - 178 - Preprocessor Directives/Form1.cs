

#define Adam1 // symbol, 
#define Bob1
//#undef Adam1


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___178___Preprocessor_Directives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if Adam1 // only runs code if Adam1 is defined // or #warn
#error Adam1 is defined

            MessageBox.Show("Test");
#elif Bob1 // else so it'll never go to it unless Adam1 isn't defined
            MessageBox.Show("Bob is defined");
#else
            MessageBox.Show("Nothing is defined");

#endif // Adam1 remind you
        }
    }
}
