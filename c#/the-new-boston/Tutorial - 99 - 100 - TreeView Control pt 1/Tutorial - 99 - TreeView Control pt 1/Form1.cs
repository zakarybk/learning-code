using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___99___TreeView_Control_pt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People"); // Adds to root
            treeView1.Nodes.Add("Animals");

            treeView1.Nodes[0].Nodes.Add("Adam"); // 0 is people
            treeView1.Nodes[0].Nodes.Add("Sam");
            treeView1.Nodes[0].Nodes.Add("Bob");

            treeView1.Nodes[1].Nodes.Add("Dog");
            treeView1.Nodes[1].Nodes.Add("Cat");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Spot"); // Dog is 0 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //treeView1.SelectedNode.Remove(); // removes selected
            //treeView1.Nodes.Clear(); // removes all
            RemoveChecked(treeView1.Nodes);
        }
        List<TreeNode> tnList = new List<TreeNode>();
        void RemoveChecked(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
                if (tn.Checked) tnList.Add(tn); // would only work on root folders unless we use recursion
                else if (tn.Nodes.Count != 0) RemoveChecked(tn.Nodes);   // If this node has nodes then look through those as well
            // Now that we have the checked nodes, remove them
            foreach (TreeNode tn in tnList)
                treeView1.Nodes.Remove(tn);
        }
    }
}
