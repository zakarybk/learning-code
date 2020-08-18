using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// arrow -> edit items on combo box to add new. Only needs new lines between each
// Dropdown style to dropdownlist so they can only pick rather than write.
namespace Tutorial___89___ComboBox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Adam") MessageBox.Show("Test");
            comboBox1.Items[0] = "Sam";  // array of items
            comboBox1.Items.Add("Steve");
            MessageBox.Show(comboBox1.Items.Count.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
