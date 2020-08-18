using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial___88___Multi_Document_Interface_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this accesses the class we're inside of!
            this.IsMdiContainer = true; // Cna now have forms inside of it
            Form2 f2 = new Form2();
            f2.MdiParent = this; // Puts Form2 inside of Form1 so that it cannot be moved outside. You alos get grey background.
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this; 
            f3.Show();
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.LayoutMdi(MdiLayout.ArrangeIcons); // moves all minimised to the bottom and sorts them
            //this.LayoutMdi(MdiLayout.Cascade); // makes them wider and taller
            //this.LayoutMdi(MdiLayout.TileHorizontal); // tiles them horizontally (re-sizes)
            this.LayoutMdi(MdiLayout.TileVertical); // tiles them vertically (re-sizes)

        }
    }
}
