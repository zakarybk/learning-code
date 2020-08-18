using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Explicit -> user has to do something to tell the complier
// Implicit -> Automatic
namespace Tutorial___152___Making_Conversion_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item i = (Item)3; // cast 3 into Item // Explicit
            Item item = 3; // Implicit

        }
    }
    class Item
    {
        public int Price
        {
            get;
            set;
        }

        // Can only pick one method
        public static explicit operator Item(int itemPrice)   // turning interger into item
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        }
        public static implicit operator Item(int itemPrice)  
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        }
    }  
}
