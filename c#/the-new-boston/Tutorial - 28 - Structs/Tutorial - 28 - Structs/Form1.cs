﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___28___Structs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client1 = new Client();
            client1.Name = "Adam";
            client1.Age = 15;
            //client1.ClearClientInfo(); // Removes all their info ezzz pez
        }
    }
}
