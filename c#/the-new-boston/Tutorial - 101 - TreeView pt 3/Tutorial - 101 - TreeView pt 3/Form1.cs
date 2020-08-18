using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tree node props, image size and Images (collection)
// treeview image list (prop) _> select list
namespace Tutorial___101___TreeView_pt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn.Text = "Person";
            tn.ImageIndex = 0;  // index in image list (collection) that the person is in.
            tn.SelectedImageIndex = 0; // stop the image chaning on select
            treeView1.Nodes.Add(tn);
            TreeNode t = new TreeNode();
            t.Text = "Animal";
            t.ImageIndex = 1;  // index in image list (collection) that the person is in.
            t.SelectedImageIndex = 1; // stop the image chaning on select
            treeView1.Nodes.Add(t);
            TreeNode tc = new TreeNode();
            tc.Text = "Elephant";
            tc.ImageIndex = 1;  // index in image list (collection) that the person is in.
            tc.SelectedImageIndex = 1; // stop the image chaning on select
            treeView1.Nodes[1].Nodes.Add(tc);

        }
    }
}
