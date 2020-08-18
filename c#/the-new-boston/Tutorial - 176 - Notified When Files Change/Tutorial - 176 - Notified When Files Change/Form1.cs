using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// file system watcher

namespace Tutorial___176___Notified_When_Files_Change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            fsw.NotifyFilter = NotifyFilters.LastWrite;
            fsw.Filter = "*.txt"; // only one type of extension, can also put name "*Document.txt"
            fsw.Changed += Fsw_Changed; // tab x2
            //fsw.Renamed += Fsw_Renamed;
            fsw.EnableRaisingEvents = true; // set to true so events can be raised
        }

        private void Fsw_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show("You have re-named a txt file.");
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("You have saved a txt file.");
        }
    }
}
