using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___147___Checking_Controls_on_Leave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; // make it appear on country
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // when user slectes a different control
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must provide a name");
                textBox1.Select(); // puts their cursor in the text box (typing cursor)
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a country");
                comboBox1.Select();
            }
        }
    }
}
