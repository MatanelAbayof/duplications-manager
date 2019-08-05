﻿namespace DuplicationsManager.Controls
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
            this.SuspendLayout();
            // 
            // label_filePathTitle
            // 
            this.label_filePathTitle.AutoSize = true;
            this.label_filePathTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_filePathTitle.Location = new System.Drawing.Point(18, 38);
            this.label_filePathTitle.Name = "label_filePathTitle";
            this.label_filePathTitle.Size = new System.Drawing.Size(111, 25);
            this.label_filePathTitle.TabIndex = 0;
            this.label_filePathTitle.Text = "File path:";
            // 
            // linkLabel_filePath
            // 
            this.linkLabel_filePath.AutoSize = true;
            this.linkLabel_filePath.Location = new System.Drawing.Point(122, 38);
            this.linkLabel_filePath.Name = "linkLabel_filePath";
            this.linkLabel_filePath.Size = new System.Drawing.Size(45, 25);
            this.linkLabel_filePath.TabIndex = 1;
            this.linkLabel_filePath.TabStop = true;
            this.linkLabel_filePath.Text = "link";
            // 
            // button_openFile
            // 
            this.button_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openFile.Location = new System.Drawing.Point(1503, 25);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(166, 50);
            this.button_openFile.TabIndex = 2;
            this.button_openFile.Text = "Open file";
            this.button_openFile.UseVisualStyleBackColor = true;
            // 
            // button_openFolder
            // 
            this.button_openFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openFolder.Location = new System.Drawing.Point(1503, 103);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(166, 50);
            this.button_openFolder.TabIndex = 3;
            this.button_openFolder.Text = "Open folder";
            this.button_openFolder.UseVisualStyleBackColor = true;
            // 
            // label_fileSize
            // 
            this.label_fileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_fileSize.AutoSize = true;
            this.label_fileSize.Location = new System.Drawing.Point(18, 128);
            this.label_fileSize.Name = "label_fileSize";
            this.label_fileSize.Size = new System.Drawing.Size(62, 25);
            this.label_fileSize.TabIndex = 4;
            this.label_fileSize.Text = "0 MB";
            // 
            // label_fileLength
            // 
            this.label_fileLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_fileLength.AutoSize = true;
            this.label_fileLength.Location = new System.Drawing.Point(241, 127);
            this.label_fileLength.Name = "label_fileLength";
            this.label_fileLength.Size = new System.Drawing.Size(67, 25);
            this.label_fileLength.TabIndex = 5;
            this.label_fileLength.Text = "0 Sec";
            // 
            // DupMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label_fileLength);
            this.Controls.Add(this.label_fileSize);
            this.Controls.Add(this.button_openFolder);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.linkLabel_filePath);
            this.Controls.Add(this.label_filePathTitle);
            this.Name = "DupMatch";
            this.Size = new System.Drawing.Size(1699, 173);
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
    }
}