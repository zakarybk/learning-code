using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___25___Inheritance_and_Overriding
{
    class MyClass
    {
        public string Name = "Bob";
        //public int Age = 10;
        //public void ShowMessage(string Message)
        protected int Age = 10; // protected makes it so they cannot be accessed outside the class unless inherited
        //protected void ShowMessage(string Message)
        //public void ShowMessage(string Message)
        public virtual void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }

    class MySecondClass : MyClass // inherit from MyClass, all members which aren't private are now in here -- derrived from MyClass
    {
        public string HairColour = "Brown";
        /*
        public void MessageBoxSpecial()
        {
            //System.Windows.Forms.MessageBox.Show(base.Age.ToString()); // Can use base to access all the non-private members of MyClass
            //base.ShowMessage(base.Age.ToString());
        }
        */
        //public new void ShowMessage(string message)   // Will replace the inherited if both public, but also if different??? --> Keyword new so it knows to use this one
        public override void ShowMessage(string message) // Same as new void, alternate way, only works if the function is virtual
        {
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }
    }
}
