using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___103___Accessing_All_Controls_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // group box is called a container, it can hold controls inside of it
            //foreach (Control c in this.Controls) // every control in the form, it however can't re-name stuff inside group boxes (called a nested control)
            //    c.Text = "Adam";
            AccessAll(this.Controls);
        }
        void AccessAll(Control.ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                ////c.Text = "Adam";
                ////c.Enabled = false;
                ////if (c is Button) c.Enabled = false; // only disable buttons
                //if (c is CheckBox)
                //{
                //    CheckBox ch = c as CheckBox; // converts control into a checkbox so then we can use the properties
                //    ch.Checked = true; // only in checkbox class
                //}
                if (c is Button)
                {
                    Button b = c as Button; // Cast c as button
                    // No matter which button you click, it'll go to this method
                    b.Click += B_Click; //+= tab
                }
                if (c.HasChildren) AccessAll(c.Controls);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
