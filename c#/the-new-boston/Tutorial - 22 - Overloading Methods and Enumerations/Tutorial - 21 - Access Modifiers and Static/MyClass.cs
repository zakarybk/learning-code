using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        enum Names : byte   // instead of interager, it's now byte
        {
            Adam,   // Adam = 1, to change the number, ones after will always be higher
            Joe,
            Bob,
        }

        string Name;
        public MyClass(string name)
        {
            Name = name;
        }
       
        public string name()
        {
            return Name;
        }

        Names myName = Names.Adam;

       
        public static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        // overloading a method, can only do with different paramterers 
        public static void ShowMessage(int message)
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());
        }
    }
}


