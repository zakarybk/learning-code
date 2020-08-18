using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___29___Partial
{
    partial class MyClass   // makes class partical. If two are created with the same name, they would combine into one class!
    {
        public string Name = "Mr.Smith";
        public int Age = 38;
        partial void Message(string message);   // We cannot but {} down in this partial class

    }
}
