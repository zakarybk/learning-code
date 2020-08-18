using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___168___Make_a_Class_for_a_Foreach_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCollection mc = new MyCollection("Adam");
            foreach (string s in mc)
                MessageBox.Show(s);

        }
    }

    class MyCollection : IEnumerable, IEnumerator
    {
        List<string> Names = new List<string>();
        int position = -1;
        public MyCollection(string name)
        {
            Names.Add(name);
        }

        public bool MoveNext()
        {
            position++;
            return (position < Names.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return Names[position]; }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
