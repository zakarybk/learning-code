﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___26___More_on_Inheritance_and_Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MyThirdClass mtc = new MyThirdClass();
            //mtc.ShowMessage("Yellow!");
            MySecondClass msc = new MySecondClass();
            msc.MyVoid();
        }
    }
}
