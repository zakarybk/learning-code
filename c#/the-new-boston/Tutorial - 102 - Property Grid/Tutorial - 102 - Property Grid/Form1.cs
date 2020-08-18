using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___102___Property_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Person p = new Person(); // using the class we made below
        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "Adam";
            p.Age = 15;
            p.Email = "xMeAdamx@gmail.com";
            propertyGrid1.SelectedObject = p; // Add to grib
            Reload();
        }
        void Reload()
        {
            textBox1.Text = p.Name;
            textBox2.Text = p.Age.ToString();
            textBox3.Text = p.Email;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Reload(); // see if we changed the value
        }
    }
    // Another class!
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
