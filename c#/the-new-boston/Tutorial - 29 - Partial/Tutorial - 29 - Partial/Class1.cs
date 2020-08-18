using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___29___Partial
{
    partial class MyClass   // 2nd one which will merge with the first
    {
        public string HairColour = "Brown";
        public bool Glasses = false;
        // Cannot put access modifiers on partial methods (public, private, protected). They always remian private!
        partial void Message(string message)    // Can only use this method inside of its class as it's a partial method
        {
            System.Windows.Forms.MessageBox.Show(message);   // mbox tab x2 to bring message box code up!
        }
        // But we can create another public method which can display this message
        public void ShowMessage(string message)
        {
            Message(message);
        }
    }
}
