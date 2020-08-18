using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Tutorial___72___WebClient_pt_1_Status_Log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // System.Net
        private void Form1_Load(object sender, EventArgs e)
        {
            // I'm using pasetbin, TheNewBoston used webs.com
            WebClient wc = new WebClient();
            textBox1.Text = wc.DownloadString("http://pastebin.com/raw/VpcgEmQw");

        }
    }
}
