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

namespace vimViewer
{
    public partial class Form1 : Form
    {
        string[] currentDirFiles;
        string currentDir = @"e:\tmp\tmp\";
        int counter = 0;
        int filesInDir = 0;

        public Form1()
        {
            InitializeComponent();
            var t = getFilesCount(currentDir);
            currentDirFiles = t.Item2;
            filesInDir = t.Item1;
        }

        private Tuple<int, string[]> getFilesCount(string dirName)
        {
            string[] dirFilesList = Directory.GetFiles(dirName);
            int filesCount = dirFilesList.Length;
            return Tuple.Create(filesCount, dirFilesList);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
                
            }
        }

        private void opernDirButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
                currentDir = folderBrowserDialog1.SelectedPath;


            }
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {

            if (counter < filesInDir - 1)
            {
                pictureBox1.Load(currentDirFiles[counter]);
                counter++;


            }
            else
            {
                pictureBox1.Load(currentDirFiles[counter]);
                counter = 0;

            }

        }

        private void previousImageButton_Click(object sender, EventArgs e)
        {
            if (counter < filesInDir - 1)
            {
                pictureBox1.Load(currentDirFiles[counter]);
                counter++;


            }
            else
            {
                pictureBox1.Load(currentDirFiles[counter]);
                counter = 0;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
