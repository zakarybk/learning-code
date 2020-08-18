using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// already knew it
namespace Tutorial___143___Comments_and_Descriptions
{
    ///  <sumary>
    ///  Gives your class method a desc!
    /// </sumary>
    public class Client
    {
        internal string Name
        {
            get;
            set;
        }
    }
    public class myClass
    {
        ///  <sumary>
        ///  Gives you Adam
        /// </sumary>
        void Adam()
        {
            Client c = new Client();
            //c.
            // doesn't seem to work..
            // you now have to use xml documents.. https://msdn.microsoft.com/en-us/library/x4sa0ak0.aspx
        }

    }
}