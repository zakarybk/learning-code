using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// program class to set load priority
namespace Tutorial___140___Splash_Screen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
        Timer t;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            // runs when form is shown
            t = new Timer();
            t.Interval = 2000; // after 2 seconds
            t.Start();
            t.Tick += T_Tick; // += tab
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
