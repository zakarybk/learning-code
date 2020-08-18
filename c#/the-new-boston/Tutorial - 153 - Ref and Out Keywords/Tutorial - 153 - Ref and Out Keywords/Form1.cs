using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___153___Ref_and_Out_Keywords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = 3; // needs to be set to somehting for ref
            // when using out, we don't have to set it to anything
            string name;
            Modify(ref Age, out name); // ref! passing through as reference so that we can change Age with a function
            MessageBox.Show(Age.ToString());
            MessageBox.Show(name);
        }
        void Modify(ref int age, out string Name) // now we can make changes to the Age var
        {
            Name = "Adam"; // however if using out you must set Name
            age += 5;
        }
    }
}
