using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___24___Throwing_Exceptions
{
    class MyClass
    {
        static Exception myException = new Exception("Damn exceptions!");
        public static void CheckString(string myString)
        {
            //if (myString == "") throw new Exception("String cannot be empty!"); // Throw an exception!
            if (myString == "") throw myException;
        }
    }
}
