using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___35___More_Variable_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte myByte = 255;     // 0-255, un-signed
            sbyte smyByte = -6; // Can be negative as well

            // All these are signed already as can be positive/negative
            short myShort = 0;  // 16 bit interger
            Int16 int16 = myShort; // same as above
            int myInt = 0; // 32 bit interger
            Int32 myInt32 = myInt; // same as above
            long myLong = 0; // 64 bits long
            Int64 myInt64 = myLong // same as above

            // un-signed number is 0 and above ONLY, put u infront to make it un-sisgned
            uint umyInt = 64;
            UInt32 umyInt32 = 64;

            // float is a floating point interger. Used for very large/small numbers
            float myFloat = 4364527547; // Only accurite upto 7 digits long
            float myFloatDecimal = 0.5F; // add f to tell it that it's a float and then it can store decimals!

            double d = 0.53415; //These can take decimals as well but without the F

            char c = 'd';   // Cannot represent more than one chacrter at a time
        }
    }
}
