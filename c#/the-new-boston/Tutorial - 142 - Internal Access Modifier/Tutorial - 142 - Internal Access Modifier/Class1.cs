using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___142___Internal_Access_Modifier
{
    namespace Clients
    {
        internal class Client // can only be called inside the same project/file
        {
            public string Name
            {
                get;
                set;
            }
            public int Age
            {
                get;
                set;
            }
            public string Email
            {
                get;
                set;
            }
        }
    }
    class myClass
    {
        void MyMethod()
        {
            Clients.Client c = new Clients.Client(); 
        }
    }
}
