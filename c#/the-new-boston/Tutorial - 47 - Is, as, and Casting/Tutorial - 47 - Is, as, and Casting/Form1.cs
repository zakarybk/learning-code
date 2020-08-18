using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___47___Is__as__and_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //object myObject = "Adam";
            //// (string) can be used instead of .ToString()
            //if (myObject is string) MessageBox.Show((string)myObject);// checks to see if the object is a string

            // Get our button
            Control myControl = button1;
            // If our control (button) is a button
            if (myControl is Button)
            {
                // Set a Button variable, also works with object etc
                Button myButton = (Button)myControl; // Or myControl as Button
                // Output our button's text
                MessageBox.Show(myButton.Text);
            }
        }
    }
}
