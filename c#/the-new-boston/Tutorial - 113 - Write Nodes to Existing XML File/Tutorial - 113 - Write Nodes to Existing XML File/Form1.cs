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

namespace Tutorial___113___Write_Nodes_to_Existing_XML_File
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
            xDoc.Load("I:\\C#\\TheNewBoston\\Tutorial - 113 - Write Nodes to Existing XML File\\People.xml");
            XmlNode person = xDoc.CreateElement("Person");
            // Name
            XmlNode name = xDoc.CreateElement("Name");
            name.InnerText = textBox1.Text;
            person.AppendChild(name); // Add the name to the person
            // Age
            XmlNode age = xDoc.CreateElement("Age");
            age.InnerText = numericUpDown1.Value.ToString();
            person.AppendChild(age);
            // Email
            XmlNode email = xDoc.CreateElement("Age");
            email.InnerText = textBox2.Text;
            person.AppendChild(email);
            // Save
            xDoc.DocumentElement.AppendChild(person); // Add the person to our document (add to root node)
            xDoc.Save("I:\\C#\\TheNewBoston\\Tutorial - 113 - Write Nodes to Existing XML File\\People.xml");

        }
    }
}
