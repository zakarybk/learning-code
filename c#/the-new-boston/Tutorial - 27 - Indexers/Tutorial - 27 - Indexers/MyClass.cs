using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___27___Indexers
{
    class MyClass
    {
        public string this[int index]
        {
            get { return myArray[index]; } // Must tell compiler what we're doing with index
            set { myArray[index] = value; } // value == whatever the user sets, delete set to make it read only
        }
        string[] myArray = { "Adam", "Bob", "Joe" };
    }
}
