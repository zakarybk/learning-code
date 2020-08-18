using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___81___ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            //cd.AllowFullOpen = false; // don't want them to be able to create custom colour
            cd.FullOpen = true; // as soon as you open dialog, it shows custom colour
            cd.ShowHelp = true; // help button appears in dialog, but needs method
            cd.HelpRequest += Cd_HelpRequest; // += tab 
            if (cd.ShowDialog() == DialogResult.OK) // do this with any dialog
                button1.BackColor = cd.Color;

        }

        private void Cd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("You want help? Hhahahaha noob");
        }
    }
}
