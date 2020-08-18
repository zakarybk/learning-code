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
//using System.Security.Cryptography;
namespace Tutorial___115___MD5_and_SHA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //UTF8Encoding utf8 = new UTF8Encoding();
            //MessageBox.Show(BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(textBox1.Text))));
            SHA256CryptoServiceProvider sha1 = new SHA256CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            MessageBox.Show(BitConverter.ToString(sha1.ComputeHash(utf8.GetBytes(textBox1.Text))));
        }
    }
}
