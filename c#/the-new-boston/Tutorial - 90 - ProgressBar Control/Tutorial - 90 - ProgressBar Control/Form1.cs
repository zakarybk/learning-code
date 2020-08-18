﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___90___ProgressBar_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value += 10;
            // Use step so it cannot go over
            progressBar1.PerformStep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;
        }
    }
}
