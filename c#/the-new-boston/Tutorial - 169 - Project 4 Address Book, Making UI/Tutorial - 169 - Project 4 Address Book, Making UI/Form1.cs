using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Tutorial___169___Project_4_Address_Book__Making_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            // AppData path
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // AppData folder
            if (!Directory.Exists(path + "\\Address Book - Tutorial 170"))
                Directory.CreateDirectory(path + "\\Address Book - Tutorial 170");
            // Xml File
            if (!File.Exists(path + "\\Address Book - Tutorial 170\\settings.xml"))
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Address Book - Tutorial 170\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("People");
                xW.WriteEndElement();
                xW.Close();
                // File.Create(path + "\\Address Book - Tutorial 170\\settings.xml");
            }
            // Read existing and add
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book - Tutorial 170\\settings.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("People/Person")) // since there are multiple person nodes
            {
                Person p = new Person();
                p.Name = xNode.SelectSingleNode("Name").InnerText;
                p.Email = xNode.SelectSingleNode("Email").InnerText;
                p.StreeAddress = xNode.SelectSingleNode("Address").InnerText;
                p.AdditionalNotes = xNode.SelectSingleNode("Notes").InnerText;
                p.Birthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Birthday").InnerText));  // int 64 is the same as a long, 64 bit
                people.Add(p); // add them
                listView1.Items.Add(p.Name); // add to list
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.Email = textBox2.Text;
            p.StreeAddress = textBox3.Text;
            p.Birthday = dateTimePicker1.Value;
            p.AdditionalNotes = textBox4.Text;
            people.Add(p);
            listView1.Items.Add(p.Name);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // view info on click
            try
            {
                textBox1.Text = people[listView1.SelectedItems[0].Index].Name;
                textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
                textBox3.Text = people[listView1.SelectedItems[0].Index].StreeAddress;
                textBox4.Text = people[listView1.SelectedItems[0].Index].AdditionalNotes;
                dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
        }

        void Remove()
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                people.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch
            {
                // nothing!
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                people[listView1.SelectedItems[0].Index].Name = textBox1.Text;
                people[listView1.SelectedItems[0].Index].Email = textBox2.Text;
                people[listView1.SelectedItems[0].Index].StreeAddress = textBox3.Text;
                people[listView1.SelectedItems[0].Index].AdditionalNotes = textBox4.Text;
                people[listView1.SelectedItems[0].Index].Birthday = dateTimePicker1.Value;
                listView1.SelectedItems[0].Text = textBox1.Text;
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\Address Book - Tutorial 170\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll(); // remove all children nodes from People node
            foreach (Person p in people)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xAddress = xDoc.CreateElement("Address");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");

                xName.InnerText = p.Name;
                xEmail.InnerText = p.Email;
                xAddress.InnerText = p.StreeAddress;
                xNotes.InnerText = p.AdditionalNotes;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString(); // a long

                xTop.AppendChild(xName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xNotes);
                xTop.AppendChild(xBirthday);
                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\Address Book - Tutorial 170\\settings.xml");
        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string StreeAddress
        {
            get;
            set;
        }
        public string AdditionalNotes
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
    }
}
