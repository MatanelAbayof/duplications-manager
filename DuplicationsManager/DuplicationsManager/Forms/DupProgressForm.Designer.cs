namespace DuplicationsManager.Forms
{
    partial class DupProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DupProgressForm));
            this.label_checkedFolderTitle = new System.Windows.Forms.Label();
            this.linkLabel_checkedFolder = new System.Windows.Forms.LinkLabel();
            this.progressBar_checkDirs = new System.Windows.Forms.ProgressBar();
            this.label_workingMessage = new System.Windows.Forms.Label();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.button_stopBuildResults = new System.Windows.Forms.Button();
            this.backgroundWorker_buildResults = new System.ComponentModel.BackgroundWorker();
            this.panel_progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_checkedFolderTitle
            // 
            this.label_checkedFolderTitle.AutoSize = true;
            this.label_checkedFolderTitle.Location = new System.Drawing.Point(13, 29);
            this.label_checkedFolderTitle.Name = "label_checkedFolderTitle";
            this.label_checkedFolderTitle.Size = new System.Drawing.Size(163, 25);
            this.label_checkedFolderTitle.TabIndex = 0;
            this.label_checkedFolderTitle.Text = "Checked folder:";
            // 
            // linkLabel_checkedFolder
            // 
            this.linkLabel_checkedFolder.AutoSize = true;
            this.linkLabel_checkedFolder.Location = new System.Drawing.Point(172, 30);
            this.linkLabel_checkedFolder.Name = "linkLabel_checkedFolder";
            this.linkLabel_checkedFolder.Size = new System.Drawing.Size(0, 25);
            this.linkLabel_checkedFolder.TabIndex = 1;
            this.linkLabel_checkedFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_checkedFolder_LinkClicked);
            // 
            // progressBar_checkDirs
            // 
            this.progressBar_checkDirs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_checkDirs.Location = new System.Drawing.Point(22, 111);
            this.progressBar_checkDirs.Name = "progressBar_checkDirs";
            this.progressBar_checkDirs.Size = new System.Drawing.Size(1219, 75);
            this.progressBar_checkDirs.TabIndex = 2;
            // 
            // label_workingMessage
            // 
            this.label_workingMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_workingMessage.AutoSize = true;
            this.label_workingMessage.Location = new System.Drawing.Point(466, 35);
            this.label_workingMessage.Name = "label_workingMessage";
            this.label_workingMessage.Size = new System.Drawing.Size(346, 25);
            this.label_workingMessage.TabIndex = 3;
            this.label_workingMessage.Text = "Please wait while building results...";
            // 
            // panel_progress
            // 
            this.panel_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_progress.Controls.Add(this.button_stopBuildResults);
            this.panel_progress.Controls.Add(this.label_workingMessage);
            this.panel_progress.Controls.Add(this.progressBar_checkDirs);
            this.panel_progress.Location = new System.Drawing.Point(12, 80);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(1265, 309);
            this.panel_progress.TabIndex = 4;
            // 
            // button_stopBuildResults
            // 
            this.button_stopBuildResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stopBuildResults.Location = new System.Drawing.Point(501, 221);
            this.button_stopBuildResults.Name = "button_stopBuildResults";
            this.button_stopBuildResults.Size = new System.Drawing.Size(250, 53);
            this.button_stopBuildResults.TabIndex = 4;
            this.button_stopBuildResults.Text = "Stop";
            this.button_stopBuildResults.UseVisualStyleBackColor = true;
            this.button_stopBuildResults.Click += new System.EventHandler(this.Button_stopBuildResults_Click);
            // 
            // backgroundWorker_buildResults
            // 
            this.backgroundWorker_buildResults.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_buildResults_DoWork);
            this.backgroundWorker_buildResults.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_buildResults_ProgressChanged);
            this.backgroundWorker_buildResults.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_buildResults_RunWorkerCompleted);
            // 
            // DupProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 412);
            this.Controls.Add(this.panel_progress);
            this.Controls.Add(this.linkLabel_checkedFolder);
            this.Controls.Add(this.label_checkedFolderTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1315, 483);
            this.Name = "DupProgressForm";
            this.Text = "Buliding results...";
            this.panel_progress.ResumeLayout(false);
            this.panel_progress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_checkedFolderTitle;
        private System.Windows.Forms.LinkLabel linkLabel_checkedFolder;
        private System.Windows.Forms.ProgressBar progressBar_checkDirs;
        private System.Windows.Forms.Label label_workingMessage;
        private System.Windows.Forms.Panel panel_progress;
        private System.ComponentModel.BackgroundWorker backgroundWorker_buildResults;
        private System.Windows.Forms.Button button_stopBuildResults;
    }
}