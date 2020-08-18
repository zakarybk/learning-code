using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___30___Abstract
{
    abstract class MyClass  // useful to be abstract if everything is public/static
    {
        public static string Name = "Adam";
        public static int Age = 15;
        public static void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);   //mbot
        }
        // Used to be overriden in a dirrived class. Class needs to be abstract to have abstract methods
        public abstract void ShowMessage(string messgae);    // As it's an abstract modifier it has to have an access modifier. No body on abstract --> NO {}

    }
    class MySecondClass : MyClass
    {
        public override void ShowMessage(string messgae)
        {
            System.Windows.Forms.MessageBox.Show(messgae);
        }
    }
}
