using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        string Name;
        public MyClass(string name)
        {
            Name = name;
        }
        // default is private, so remove public to make private, or replace with private!
        public string name()
        {
            return Name;
        }

        //  public static, can be acessed with MyClass.ShowMessage
        public static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
    }
}

// public/private --> access modifier
// static just a modifier
