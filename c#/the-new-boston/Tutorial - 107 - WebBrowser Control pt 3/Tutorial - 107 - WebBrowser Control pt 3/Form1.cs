using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// web props url
namespace Tutorial___107___WebBrowser_Control_pt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("lst-ib").InnerText = textBox1.Text; // set google text box to our textbox text
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("sfdiv").InvokeMember("Click"); // invoke our method on the webpage, all buttons are Click
        }
    }
}
