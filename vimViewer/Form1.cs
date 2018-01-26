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
        string[] currentDirFiles; // array of files of a chosen directory
        string currentDir = @"e:\tmp\tmp\"; // default directory
        int counter; // current images's index currentDirFiles[0 1 2 |3| 4 5 6] for example
        int filesInDir; // array length (i.e. files in a directory)
        bool prev = false;
        bool next = false;
        bool zeroIndexLoaded = false;

        public Form1()
        {
            InitializeComponent();
            var t = getFilesCount(currentDir);
            currentDirFiles = t.Item2;
            filesInDir = t.Item1;
            counter = 0;
            //showImage(currentDirFiles[0], counter);
        }
        private void showImage(string fileName, int counter)
        {
            pictureBox1.Load(fileName);
            label1.Text = fileName;
            label2.Text = $"{counter}";
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
                var t = getFilesCount(currentDir);
                currentDirFiles = t.Item2;
                filesInDir = t.Item1;
            }
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {
            if (prev)
            {
                counter = counter + 2;
            }
            if (counter <= filesInDir - 1)
            {
                showImage(currentDirFiles[counter], counter);
                counter++;
            }
            else
            {
                counter = 0;
                showImage(currentDirFiles[counter], counter);

            }
            next = true;
            prev = false;

        }

        private void previousImageButton_Click(object sender, EventArgs e)
        {
           if (next)
            {
                counter = counter - 2;
            }
           if (counter >= 0)
            {
                showImage(currentDirFiles[counter], counter);
                counter = counter -1;
            }
            else
            {
                counter = filesInDir - 1;
                showImage(currentDirFiles[counter], counter);
            }
            prev = true;
            next = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
