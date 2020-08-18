using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___144___Goto_Keyword_and_Regions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string Adam = "Blah";
            //switch (Adam)
            //{
            //    case "Adam":
            //        MessageBox.Show("Hello");
            //        break;
            //    default:
            //        MessageBox.Show("The default");
            //        goto case "Adam";
            //}
            for (; ;)
            {
                goto MyCode; // jump to MyCode!, It won't go back to the for loop. Jump then stop
            }
        MyCode:
            {
                MessageBox.Show("Hello");
            }
        }
        // Doesn't need to have a name, lets you close it to hide it
        #region MyRegion 
        /*
         * 
         *  code leet
         * 
         * 
          */
        #endregion
    }
}
