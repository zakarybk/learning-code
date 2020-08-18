using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___30___Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cannot access static from mc variable made from MyClass, however we can using MyClass. (with . to show the stuff)
            //MyClass mc = new MyClass(); --> When the class is abstract, we cannot access it this way at least
        }
    }
}
