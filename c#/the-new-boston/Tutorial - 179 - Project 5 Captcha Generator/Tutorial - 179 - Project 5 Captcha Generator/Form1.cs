using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;

//using System.Collections.Generic; --> to use lists
// md5
namespace Tutorial___179___Project_5_Captcha_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Strings = new List<string>();

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (Image i in GenerateCaptchas(Convert.ToInt32(textBox1.Text)))
            Image[] images = GenerateCaptchas(Convert.ToInt32(textBox1.Text));
            int g = 0;
            foreach (Image image in images)
            {
                image.Save(label1.Text + "\\" + Strings[g] + ".png");
                g++;
            }
        }

        Image[] GenerateCaptchas(int amount)
        {
            Image[] images = new Image[amount];
            Random ran = new Random(); // make it more random by moving it outside
            for (int z = 0; z < amount; z++) // loop throught he correct amount
            {
                Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height); // drawing everything into here
                                                                         //Graphics g = panel1.CreateGraphics();
                Graphics g = Graphics.FromImage(bitmap); // captcha will be drawn into image
                g.Clear(panel1.BackColor); // remove old drawings
                SolidBrush b = new SolidBrush(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
                Pen p = new Pen(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
                char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                string randomString = "";
                for (int i = 0; i < 6; i++)
                {
                    randomString += chars[ran.Next(0, 26)];//.ToString();
                }
                byte[] buffer = new byte[randomString.Length]; // buffer
                int y = 0;
                foreach (char c in randomString.ToCharArray())
                {
                    buffer[y] = (byte)c; // cast as a byte
                    y++;
                }
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();          // replace - wtih 
                string md5String = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", ""); // turn out byte[] into md5 hash! BitConverter.ToString to turn byte array to string
                Strings.Add(md5String); // add the hash to our list
                FontFamily ff = new FontFamily("Arial");
                Font f = new Font(ff, 14);
                g.DrawString(randomString, f, b, 20, 20);
                for (int i = 0; i < 6; i++)
                {
                    int j = ran.Next(0, 2); // it'll never get the max, always below
                    if (j == 0) g.DrawRectangle(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 111), ran.Next(0, 60));
                    else if (j == 1) g.DrawEllipse(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 111), ran.Next(0, 60));
                    p.Color = Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                }
                //panel1.BackgroundImage = bitmap;
                images[z] = bitmap;
            }
            return images; // return our array
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                label1.Text = fbd.SelectedPath; // the path they selected in folder browser dialog
            }
        }

        string md5HashedName = "";
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                md5HashedName = Path.GetFileNameWithoutExtension(ofd.SafeFileName); /// change to FileName if stuff breaks!
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] buffer = new byte[textBox2.Text.Length]; // buffer
            int y = 0;
            foreach (char c in textBox2.Text)
            {
                buffer[y] = (byte)c; // cast as a byte
                y++;
            }
            string blah = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");
            if (blah != md5HashedName)
            {
                MessageBox.Show("You got it wrong!");
            }
            else
            {
                MessageBox.Show("You got it right!");
            }
        }
    }
}
