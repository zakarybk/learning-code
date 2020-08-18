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

namespace Tutorial___112___Writing_New_XML_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xWriter = new XmlTextWriter("I:\\C#\\TheNewBoston\\Tutorial - 112 - Writing New XML file\\People.xml", Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented; // Make it readable when you open the file in a text editior 
            xWriter.WriteStartElement("People"); // <People>
            xWriter.WriteStartElement("Person"); // <Person>

            xWriter.WriteStartElement("Name"); // <Name>
            xWriter.WriteString(textBox1.Text); // textBox1.Text
            xWriter.WriteEndElement(); // </Name>

            xWriter.WriteStartElement("Age"); // <Name>
            xWriter.WriteString(numericUpDown1.Value.ToString()); // textBox1.Text
            xWriter.WriteEndElement(); // </Name>

            xWriter.WriteStartElement("Email"); // <Name>
            xWriter.WriteString(textBox2.Text); // textBox1.Text
            xWriter.WriteEndElement(); // </Name>

            xWriter.WriteEndElement(); // </Person>
            xWriter.WriteEndElement(); // </People>
            xWriter.Close(); // close it to stop opening errors
        }
    }
}
