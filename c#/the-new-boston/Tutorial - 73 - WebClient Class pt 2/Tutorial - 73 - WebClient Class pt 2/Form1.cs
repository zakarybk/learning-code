using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Tutorial___73___WebClient_Class_pt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WebClient wc = new WebClient();
                // Syncs run the code then continue with code below even if this hasn't finished
                wc.DownloadFileAsync(new Uri("http://pastebin.com/raw/VpcgEmQw"), sfd.FileName);    // Save the file to where we pick
                // tab to auto put in the code!
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted; // triggered when download complete
                // Progress, triggered everytime progress changes
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;

            }


        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // displays % in label
            label1.Text = "Progress " + e.ProgressPercentage.ToString() ;
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File has been downlaoded!");
        }
    }
}
