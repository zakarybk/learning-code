using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// view code f7
namespace Tutorial___87___Multiple_Forms
{
    public partial class Form2 : Form
    {
        // Constructor
        public Form2(string myString) // can have multiple
        {
            InitializeComponent();
            label1.Text = myString;
        }
    }
}
