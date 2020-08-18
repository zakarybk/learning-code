using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___106___WebBrowser_Control_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebBrowser wb = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            //http://www.bungie.net/Stats/Reach/Default.aspx?player=Experiment5x&sg=0
            //Experiment5x
            wb.Navigate("http://www.bungie.net/Stats/Reach/Default.aspx?player=" + textBox1.Text + "&sg=0");
            wb.DocumentCompleted += Wb_DocumentCompleted; // += tab

        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = "Last Played: " + wb.Document.GetElementById("ctl00_mainContent_lastPlayedLabel").InnerText; // inspect element -> id
        }
    }
}
