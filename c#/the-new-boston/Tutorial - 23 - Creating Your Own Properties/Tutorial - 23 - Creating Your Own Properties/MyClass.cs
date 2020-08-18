using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___23___Creating_Your_Own_Properties
{
    class MyClass
    {
        string myString;
        public MyClass(string name)
        {
            //Name = name;
            myString = name;
        }

        // Not a method so doesn't need (), it's a property
        public string Name
        {
            //get; // Allows the user to read from property
            //set; //lets the user change the value of the property
            // private set; only let the user change the value of the property inside of this class
            get { return myString; } // read only
            set
            {
                if (value == "") System.Windows.Forms.MessageBox.Show("You can't do that!") // Stop the user from imputting an empty string
            }
        }
    }
}
