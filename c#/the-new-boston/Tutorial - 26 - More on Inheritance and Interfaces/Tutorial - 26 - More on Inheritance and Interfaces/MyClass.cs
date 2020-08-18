using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___26___More_on_Inheritance_and_Interfaces
{
    class MyClass
    {
        private string Name = "Bob";
        protected int Age = 10;
        public virtual void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }

    class MySecondClass : MyClass, IMyInterface   // Can only inherit one base class, can inherit from the same class multiple times --> Add our interface
    {
        public string HairColour = "Brown";
        public override void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }
        public void MyVoid()
        {
            base.ShowMessage("My void!");
        }
    }

    /*
    class MyThirdClass : MySecondClass
    {

    }
    */

    interface IMyInterface // Start with capital I, good coding practice. Tell apart from a class easier
    {
        void MyVoid();  // Cannot add {}, that's for classes. The method cannot do anything, well be set to do anything in here
    }

}
