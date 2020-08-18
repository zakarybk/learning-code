using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___13___For_and_Foreach_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] Names = {"Bob", "Steven", "Bon Juninor", "Steven Rich", "Dead queen" };
            //for (int i = 0; i<5; i++) // remove i<5 to make it go forever like fam
            //{
            //    MessageBox.Show("Hello " + Names[i]);
            //}
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(5);
            numbers.Add(5);
            numbers.Add(5);
            foreach (int s in numbers)
                {
                    MessageBox.Show(s.ToString());
                }
        }
    }
}
