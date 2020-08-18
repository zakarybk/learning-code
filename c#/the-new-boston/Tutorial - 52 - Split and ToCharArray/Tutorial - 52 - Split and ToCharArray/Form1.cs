using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___52___Split_and_ToCharArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string names = "Adam;Bob;Harry;Katie;Sam;Chloe";
            //string[] nameArray = names.Split(';'); // like string.explode from Lua
            //foreach(string name in nameArray)
            //    MessageBox.Show(name);

            string _letters = "abcdefghijklmnopqrstuvwxyz";
            char[] letters = _letters.ToCharArray();
            foreach (char c in letters)
                MessageBox.Show(c.ToString());
        }
    }
}
