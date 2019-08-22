namespace DuplicationsManager.Controls
{
    partial class DupMatch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_filePathTitle = new System.Windows.Forms.Label();
            this.linkLabel_filePath = new System.Windows.Forms.LinkLabel();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_openFolder = new System.Windows.Forms.Button();
            this.label_fileSize = new System.Windows.Forms.Label();
            this.label_fileLength = new System.Windows.Forms.Label();
            this.button_deleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_filePathTitle
            // 
            this.label_filePathTitle.AutoSize = true;
            this.label_filePathTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_filePathTitle.Location = new System.Drawing.Point(18, 24);
            this.label_filePathTitle.Name = "label_filePathTitle";
            this.label_filePathTitle.Size = new System.Drawing.Size(111, 25);
            this.label_filePathTitle.TabIndex = 0;
            this.label_filePathTitle.Text = "File path:";
            // 
            // linkLabel_filePath
            // 
            this.linkLabel_filePath.AutoEllipsis = true;
            this.linkLabel_filePath.Location = new System.Drawing.Point(129, 24);
            this.linkLabel_filePath.Name = "linkLabel_filePath";
            this.linkLabel_filePath.Size = new System.Drawing.Size(1355, 103);
            this.linkLabel_filePath.TabIndex = 1;
            // 
            // button_openFile
            // 
            this.button_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openFile.Location = new System.Drawing.Point(1503, 13);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(166, 50);
            this.button_openFile.TabIndex = 2;
            this.button_openFile.Text = "Open file";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.Button_openFile_Click);
            // 
            // button_openFolder
            // 
            this.button_openFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_openFolder.Location = new System.Drawing.Point(1503, 77);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(166, 50);
            this.button_openFolder.TabIndex = 3;
            this.button_openFolder.Text = "Open folder";
            this.button_openFolder.UseVisualStyleBackColor = true;
            this.button_openFolder.Click += new System.EventHandler(this.Button_openFolder_Click);
            // 
            // label_fileSize
            // 
            this.label_fileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_fileSize.AutoSize = true;
            this.label_fileSize.Location = new System.Drawing.Point(18, 154);
            this.label_fileSize.Name = "label_fileSize";
            this.label_fileSize.Size = new System.Drawing.Size(62, 25);
            this.label_fileSize.TabIndex = 4;
            this.label_fileSize.Text = "0 MB";
            // 
            // label_fileLength
            // 
            this.label_fileLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_fileLength.AutoSize = true;
            this.label_fileLength.Location = new System.Drawing.Point(241, 153);
            this.label_fileLength.Name = "label_fileLength";
            this.label_fileLength.Size = new System.Drawing.Size(67, 25);
            this.label_fileLength.TabIndex = 5;
            this.label_fileLength.Text = "0 Sec";
            // 
            // button_deleteFile
            // 
            this.button_deleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deleteFile.Location = new System.Drawing.Point(1503, 139);
            this.button_deleteFile.Name = "button_deleteFile";
            this.button_deleteFile.Size = new System.Drawing.Size(168, 45);
            this.button_deleteFile.TabIndex = 6;
            this.button_deleteFile.Text = "Delete file";
            this.button_deleteFile.UseVisualStyleBackColor = true;
            this.button_deleteFile.Click += new System.EventHandler(this.Button_deleteFile_Click);
            // 
            // DupMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.button_deleteFile);
            this.Controls.Add(this.label_fileLength);
            this.Controls.Add(this.label_fileSize);
            this.Controls.Add(this.button_openFolder);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.linkLabel_filePath);
            this.Controls.Add(this.label_filePathTitle);
            this.Name = "DupMatch";
            this.Size = new System.Drawing.Size(1699, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_filePathTitle;
        private System.Windows.Forms.LinkLabel linkLabel_filePath;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.Label label_fileSize;
        private System.Windows.Forms.Label label_fileLength;
        private System.Windows.Forms.Button button_deleteFile;
    }
}
