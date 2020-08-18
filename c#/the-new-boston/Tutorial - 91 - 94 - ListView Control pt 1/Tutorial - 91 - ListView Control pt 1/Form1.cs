using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// context menu strip in props
namespace Tutorial___91___ListView_Control_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Created new item, haven't added to view
            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox3.Text);
            lvi.SubItems.Add(textBox2.Text);
            // Add it to the view!
            listView1.Items.Add(lvi);
            // Blank em
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        // context menu, double click, makes code.
        private void getNameOfItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If something is selected
            if (listView1.SelectedItems.Count != 0)
            {
                //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);  // Always 0 as we're selecting one item, displays full name
                // Now multiselect!
                foreach (ListViewItem lvi in listView1.SelectedItems)
                    MessageBox.Show(lvi.SubItems[0].Text);
            }
        }

        private void removeSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If something is selected
            if (listView1.SelectedItems.Count != 0)
            {
                // Remove selected
                foreach (ListViewItem lvi in listView1.SelectedItems)
                    lvi.Remove();
            }
        }

        private void removeAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove all
            listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove all checked
            foreach (ListViewItem lvi in listView1.Items)
                if (lvi.Checked) lvi.Remove();
        }
    }
}
