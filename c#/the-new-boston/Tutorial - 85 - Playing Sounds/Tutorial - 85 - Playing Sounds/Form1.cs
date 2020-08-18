using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
// using System.Media;
namespace Tutorial___85___Playing_Sounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    // Plays .wav
            //    SoundPlayer s = new SoundPlayer(ofd.FileName);
            //    s.Play();
            //    s.PlayLooping(); // loop it
            //    s.PlaySync(); //Freeze your application when it's playing
            //}
            //SystemSounds.Asterisk.Play();   // Play windows error sound
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
            SystemSounds.Question.Play(); // doesn't play this one!
        }
    }
}
