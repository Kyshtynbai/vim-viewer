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
        int counter;
        int filesInDir;
        bool isFullScreen = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            var t = getFilesCount(currentDir);
            currentDirFiles = t.Item2;
            filesInDir = t.Item1;
            counter = 0;
            showImage(currentDirFiles[0], counter);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Q))
            {
                this.Close();
                // return true;
            }
            if (keyData == (Keys.F))
            {
                toggleFullScreen(isFullScreen);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void showImage(string fileName, int counter)
        {
            pictureBox1.Load(fileName);
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
                pictureBox1.Load(openFileDialog1.FileName);

            }
        }

        private void opernDirButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                currentDir = folderBrowserDialog1.SelectedPath;
                var t = getFilesCount(currentDir);
                currentDirFiles = t.Item2;
                filesInDir = t.Item1;
            }
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {

            counter = counter == currentDirFiles.Length - 1 ? 0 : counter + 1;
            showImage(currentDirFiles[counter], counter);

        }

        private void previousImageButton_Click(object sender, EventArgs e)
        {

            counter = counter == 0 ? currentDirFiles.Length - 1 : counter - 1;
            showImage(currentDirFiles[counter], counter);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            toggleFullScreen(isFullScreen);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            toggleFullScreen(isFullScreen);
        }

        private void toggleFullScreen(bool isFullScreen)
        {
            if (!isFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[1].Height = 0;
                this.isFullScreen = true;

            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[1].Height = 5;
                this.isFullScreen = false;
            }
        }
    }
}
