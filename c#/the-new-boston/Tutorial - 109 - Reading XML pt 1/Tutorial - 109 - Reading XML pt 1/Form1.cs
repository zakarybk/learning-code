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

//using System.Xml;
namespace Tutorial___109___Reading_XML_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////OpenFileDialog ofd = new OpenFileDialog();
            ////ofd.Filter = "XML|*.xml";
            ////if (ofd.ShowDialog() == DialogResult.OK)
            ////{
            ////    XmlDocument xDoc = new XmlDocument();
            ////    xDoc.Load(ofd.FileName);
            ////    MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText);
            ////    MessageBox.Show(xDoc.SelectSingleNode("People/Person/Age").InnerText);
            ////    MessageBox.Show(xDoc.SelectSingleNode("People/Person/Email").InnerText);
            ////}
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("http://158.69.120.30/hackcraft/People.xml");
            //MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText);
            //MessageBox.Show(xDoc.SelectSingleNode("People/Person/Age").InnerText);
            //MessageBox.Show(xDoc.SelectSingleNode("People/Person/Email").InnerText);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);
                foreach (XmlNode node in xDoc.SelectNodes("People/Person")) // returns xml node list (looking for multiple Person nodes!)
                {
                    MessageBox.Show(node.SelectSingleNode("Name").InnerText); // Don't need People/person as we're already there
                    MessageBox.Show(node.SelectSingleNode("Age").InnerText);
                    MessageBox.Show(node.SelectSingleNode("Email").InnerText);
                }
            }
        }
    }
}
