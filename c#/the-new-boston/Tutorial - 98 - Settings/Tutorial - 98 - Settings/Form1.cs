using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Project -> project settings -> settings -> add new by typing in box + save
namespace Tutorial___98___Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.Name;
            textBox2.Text = Properties.Settings.Default.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name = textBox1.Text; // Update the property
            Properties.Settings.Default.Age = Convert.ToInt32(textBox2.Text);
            Properties.Settings.Default.ButtonA = button1; // can also set settings to other things like buttons!
            Properties.Settings.Default.Save(); // Save the property
        }
    }
}
