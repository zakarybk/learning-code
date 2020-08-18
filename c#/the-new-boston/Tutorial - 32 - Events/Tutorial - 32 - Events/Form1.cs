using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___32___Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.OnPropertyChanged += Mc_OnPropertyChanged; // += then tab x2
            mc.Name = "Adam";
        }

        private void Mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The property has changed!");
        }
    }
}
