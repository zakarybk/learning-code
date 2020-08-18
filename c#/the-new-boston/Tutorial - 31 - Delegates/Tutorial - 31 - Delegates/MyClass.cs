using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___31___Delegates
{
    class MyClass
    {
        delegate void MyDelegate(string myString);  // Delegate only runs the same type (void, int, etc)
        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage); // No (), we're adding not running
            md += ShowAnotherMessage;   // Add another to the delegate list
            // Envoke/call
            md("Adam"); // Call all methods inside delegate with the string "Adam"
        }
        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        void ShowAnotherMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show(a, "Test");
        }
    }
}
