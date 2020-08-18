using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___166___Optional_Parameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //// overloaded method
        //void ShowMessage(string message)
        //{
        //    MessageBox.Show(message);
        //}
        //// normal method
        //void ShowMessage(string message, string title)
        //{
        //    MessageBox.Show(message, title);
        //}
        // optional perapeter
        void ShowMessage(string message, string title = "Default Value", int amount = 0) // optional perameters have to be at the end so c# knows what to do, can ahve multiple
        {
            for (int i = 0; i < amount; i++)
                MessageBox.Show(message, title);
        }
    }
}
