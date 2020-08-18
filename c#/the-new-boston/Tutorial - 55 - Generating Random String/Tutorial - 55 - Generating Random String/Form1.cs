using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___55___Generating_Random_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); /// turns it into a char array ''
            Random r = new Random();
            string RandomString = "";
            for (int i = 0; i < 10; i++)
            {
                RandomString += letters[r.Next(0, 25)];
            }
            MessageBox.Show(RandomString);

        }
    }
}
