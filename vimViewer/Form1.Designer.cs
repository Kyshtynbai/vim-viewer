namespace vimViewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.previousImageButton = new System.Windows.Forms.Button();
            this.opernDirButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.openFileButton);
            this.flowLayoutPanel1.Controls.Add(this.opernDirButton);
            this.flowLayoutPanel1.Controls.Add(this.previousImageButton);
            this.flowLayoutPanel1.Controls.Add(this.nextImageButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Controls.Add(this.fullScreenButton);
            this.flowLayoutPanel1.Controls.Add(this.testButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 375);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(806, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Location = new System.Drawing.Point(408, 3);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(75, 23);
            this.fullScreenButton.TabIndex = 5;
            this.fullScreenButton.Text = "fullscreen";
            this.fullScreenButton.UseVisualStyleBackColor = true;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(327, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nextImageButton
            // 
            this.nextImageButton.Location = new System.Drawing.Point(246, 3);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(75, 23);
            this.nextImageButton.TabIndex = 2;
            this.nextImageButton.Text = "next";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.nextImageButton_Click);
            // 
            // previousImageButton
            // 
            this.previousImageButton.Location = new System.Drawing.Point(165, 3);
            this.previousImageButton.Name = "previousImageButton";
            this.previousImageButton.Size = new System.Drawing.Size(75, 23);
            this.previousImageButton.TabIndex = 3;
            this.previousImageButton.Text = "prev";
            this.previousImageButton.UseVisualStyleBackColor = true;
            this.previousImageButton.Click += new System.EventHandler(this.previousImageButton_Click);
            // 
            // opernDirButton
            // 
            this.opernDirButton.Location = new System.Drawing.Point(84, 3);
            this.opernDirButton.Name = "opernDirButton";
            this.opernDirButton.Size = new System.Drawing.Size(75, 23);
            this.opernDirButton.TabIndex = 1;
            this.opernDirButton.Text = "dir";
            this.opernDirButton.UseVisualStyleBackColor = true;
            this.opernDirButton.Click += new System.EventHandler(this.opernDirButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(3, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 375);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(39, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "full";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.257918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.74208F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(489, 3);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "TEST ROWS";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "vimViewer";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button opernDirButton;
        private System.Windows.Forms.Button previousImageButton;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button testButton;
    }
}

