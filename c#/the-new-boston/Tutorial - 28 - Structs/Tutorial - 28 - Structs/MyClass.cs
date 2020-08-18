using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___28___Structs
{
    struct Client   // Structs cannot inherit from classes or another struct. They can however inherit from interfaces!
    {
        public Client(string name)  // default constructor
        {
            Name = name;
            Age = 0;
        }
        public string Name;
        public int Age;
        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;
        }
    }
}
