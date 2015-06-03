using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSaveBrowse
{
    public partial class Form1 : Form
    {
        const string workFolder = @"C:\MyOwnApps\GitLoc\HeadFirstCsharp\WorkFolder\";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = workFolder;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|"
            + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FileName = "default_file.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenSomeFile(openFileDialog1.FileName);
            }
        }

        private void OpenSomeFile(string filename)
        {
            MessageBox.Show("Opened File: "+filename) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = workFolder;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|"
            + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveTheFile(saveFileDialog1.FileName);
            }
        }

        private void SaveTheFile(string filename)
        {
            MessageBox.Show("Saved File: " + filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = workFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BrowseTheFile(folderBrowserDialog1.SelectedPath);
            }
        }

        private void BrowseTheFile(string foldername)
        {
            MessageBox.Show("Browsed Folder: " + foldername);
        }
    }
}
