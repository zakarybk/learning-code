using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tutorial___114___Deleting_a_XML_Node
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("I:\\C#\\TheNewBoston\\Tutorial - 114 - Deleting a XML Node\\People.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("People/Person")) // for each node under person
                if (xNode.SelectSingleNode("Name").InnerText == textBox1.Text) xNode.ParentNode.RemoveChild(xNode); // removes entire entry, cannot sue RemoveAll as it leaves the person tags
            xDoc.Save("I:\\C#\\TheNewBoston\\Tutorial - 114 - Deleting a XML Node\\People.xml");
        }
    }
}
