using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___148___Overloading_Operators_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item1 = new Item();
            item1.Price = 4;
            Item item2 = new Item();
            item2.Price = 6;
            Item item3 = item1 + item2;
            MessageBox.Show(item3.Price.ToString());
            MessageBox.Show((item1 != item2).ToString());
            MessageBox.Show((item1 > item2).ToString());
            MessageBox.Show((item1 <= item2).ToString());
            item2++;
            MessageBox.Show((item2.Price).ToString());
        }
    }
    class Item
    {
        public int Price
        {
            get;
            set;
        }
        // all operators must be public and static
        // Overloaded the + operator for this class
        public static Item operator +(Item i1, Item i2) // returns the new item
        {
            Item i3 = new Tutorial___148___Overloading_Operators_pt_1.Item();
            i3.Price = i1.Price + i2.Price;
            return i3;
        }
        // to overload the != you have to also overload the ==
        public static bool operator ==(Item i1, Item i2)    // returns true or false
        {
            return i1.Price == i2.Price;
        }

        public static bool operator !=(Item i1, Item i2)    // returns true or false
        {
            return i1.Price != i2.Price; //(i1.Price != i2.Price) ? true : false;
        }

        // <, > --> goes together, must overload both
        public static bool operator <(Item i1, Item i2)
        {
            return i1.Price < i2.Price;    //(i1.Price < i2.Price) ? true : false;
        }
        public static bool operator >(Item i1, Item i2)
        {
            return i1.Price > i2.Price;
        }

        // <=, >= goes together, must overload both
        public static bool operator <=(Item i1, Item i2)
        {
            return i1.Price <= i2.Price;    //(i1.Price < i2.Price) ? true : false;
        }
        public static bool operator >=(Item i1, Item i2)
        {
            return i1.Price >= i2.Price;
        }

        //++, --
        public static Item operator ++(Item i1)
        {
            Item i3 = new Item();
            i3.Price = i1.Price + 1; // for some reason ++ won't work here
            return i3;
        }
        public static Item operator --(Item i1)
        {
            Item i3 = new Item();
            i3.Price = i1.Price - 1;
            return i3;
        }


    }
}
