namespace DuplicationsManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_checkFolder = new System.Windows.Forms.Label();
            this.textBox_checkFolder = new System.Windows.Forms.TextBox();
            this.button_browseCheckFolder = new System.Windows.Forms.Button();
            this.button_checkDupFiles = new System.Windows.Forms.Button();
            this.label_mediaTypeLabel = new System.Windows.Forms.Label();
            this.listBox_mediaType = new System.Windows.Forms.ListBox();
            this.label_mediaSortType = new System.Windows.Forms.Label();
            this.listBox_mediaSortType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_checkFolder
            // 
            this.label_checkFolder.AutoSize = true;
            this.label_checkFolder.Location = new System.Drawing.Point(13, 50);
            this.label_checkFolder.Name = "label_checkFolder";
            this.label_checkFolder.Size = new System.Drawing.Size(234, 25);
            this.label_checkFolder.TabIndex = 0;
            this.label_checkFolder.Text = "Enter a folder to check:";
            // 
            // textBox_checkFolder
            // 
            this.textBox_checkFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_checkFolder.Location = new System.Drawing.Point(18, 88);
            this.textBox_checkFolder.Name = "textBox_checkFolder";
            this.textBox_checkFolder.Size = new System.Drawing.Size(649, 31);
            this.textBox_checkFolder.TabIndex = 1;
            this.textBox_checkFolder.TextChanged += new System.EventHandler(this.TextBox_checkFolder_TextChanged);
            // 
            // button_browseCheckFolder
            // 
            this.button_browseCheckFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browseCheckFolder.Location = new System.Drawing.Point(674, 82);
            this.button_browseCheckFolder.Name = "button_browseCheckFolder";
            this.button_browseCheckFolder.Size = new System.Drawing.Size(114, 48);
            this.button_browseCheckFolder.TabIndex = 2;
            this.button_browseCheckFolder.Text = "...";
            this.button_browseCheckFolder.UseVisualStyleBackColor = true;
            this.button_browseCheckFolder.Click += new System.EventHandler(this.Button_browseCheckFolder_Click);
            // 
            // button_checkDupFiles
            // 
            this.button_checkDupFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_checkDupFiles.Location = new System.Drawing.Point(284, 396);
            this.button_checkDupFiles.Name = "button_checkDupFiles";
            this.button_checkDupFiles.Size = new System.Drawing.Size(232, 51);
            this.button_checkDupFiles.TabIndex = 3;
            this.button_checkDupFiles.Text = "Check";
            this.button_checkDupFiles.UseVisualStyleBackColor = true;
            this.button_checkDupFiles.Click += new System.EventHandler(this.Button_checkDupFiles_Click);
            // 
            // label_mediaTypeLabel
            // 
            this.label_mediaTypeLabel.AutoSize = true;
            this.label_mediaTypeLabel.Location = new System.Drawing.Point(18, 135);
            this.label_mediaTypeLabel.Name = "label_mediaTypeLabel";
            this.label_mediaTypeLabel.Size = new System.Drawing.Size(203, 25);
            this.label_mediaTypeLabel.TabIndex = 4;
            this.label_mediaTypeLabel.Text = "Choose media type:";
            // 
            // listBox_mediaType
            // 
            this.listBox_mediaType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_mediaType.FormattingEnabled = true;
            this.listBox_mediaType.ItemHeight = 25;
            this.listBox_mediaType.Location = new System.Drawing.Point(23, 176);
            this.listBox_mediaType.Name = "listBox_mediaType";
            this.listBox_mediaType.Size = new System.Drawing.Size(187, 54);
            this.listBox_mediaType.TabIndex = 5;
            // 
            // label_mediaSortType
            // 
            this.label_mediaSortType.AutoSize = true;
            this.label_mediaSortType.Location = new System.Drawing.Point(23, 247);
            this.label_mediaSortType.Name = "label_mediaSortType";
            this.label_mediaSortType.Size = new System.Drawing.Size(245, 25);
            this.label_mediaSortType.TabIndex = 6;
            this.label_mediaSortType.Text = "Choose media sort type:";
            // 
            // listBox_mediaSortType
            // 
            this.listBox_mediaSortType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_mediaSortType.FormattingEnabled = true;
            this.listBox_mediaSortType.ItemHeight = 25;
            this.listBox_mediaSortType.Location = new System.Drawing.Point(28, 289);
            this.listBox_mediaSortType.Name = "listBox_mediaSortType";
            this.listBox_mediaSortType.Size = new System.Drawing.Size(230, 79);
            this.listBox_mediaSortType.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.listBox_mediaSortType);
            this.Controls.Add(this.label_mediaSortType);
            this.Controls.Add(this.listBox_mediaType);
            this.Controls.Add(this.label_mediaTypeLabel);
            this.Controls.Add(this.button_checkDupFiles);
            this.Controls.Add(this.button_browseCheckFolder);
            this.Controls.Add(this.textBox_checkFolder);
            this.Controls.Add(this.label_checkFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(826, 526);
            this.Name = "MainForm";
            this.Text = "Duplication Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_checkFolder;
        private System.Windows.Forms.TextBox textBox_checkFolder;
        private System.Windows.Forms.Button button_browseCheckFolder;
        private System.Windows.Forms.Button button_checkDupFiles;
        private System.Windows.Forms.Label label_mediaTypeLabel;
        private System.Windows.Forms.ListBox listBox_mediaType;
        private System.Windows.Forms.Label label_mediaSortType;
        private System.Windows.Forms.ListBox listBox_mediaSortType;
    }
}