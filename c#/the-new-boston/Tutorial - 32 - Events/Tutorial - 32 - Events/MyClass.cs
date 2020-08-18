using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___32___Events
{
    class MyClass
    {
        // Can only add/take from event --> EventHandler is like a delegate
        public event EventHandler OnPropertyChanged;   // delegate follows event, changes whenever the public string name property changes
                
        string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(this, new EventArgs());   // create args
            }
        }
    }
}
