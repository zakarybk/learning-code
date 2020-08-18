using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___54___Generating_Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// random class
            Random r = new Random();
            ////MessageBox.Show(r.Next(0, 100).ToString()); // returns a random number
            //byte[] buffer = new byte[5];
            //r.NextBytes(buffer); // builds byte array with random bytes
            //MessageBox.Show(BitConverter.ToString(buffer));

            MessageBox.Show(r.NextDouble().ToString()); // random decimal

        }
    }
}
