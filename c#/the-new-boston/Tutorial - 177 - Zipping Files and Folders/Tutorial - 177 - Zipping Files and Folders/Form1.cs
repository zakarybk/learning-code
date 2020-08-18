using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
//using Ionic.Zip;
// using zip dll --> references, right click add
namespace Tutorial___177___Zipping_Files_and_Folders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    ZipFile zf = new ZipFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\MyZipFile.zip");
            //    zf.AddDirectoryByName("Adam");
            //    zf.AddFile(ofd.FileName, "Adam");
            //    zf.Save(); // builds/create zip file
            //}
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ZipFile zf = new ZipFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MyZipFile.zip");
                zf.AddDirectory(fbd.SelectedPath, "");
                zf.Save(); // builds/create zip file
            }
        }
    }
}
