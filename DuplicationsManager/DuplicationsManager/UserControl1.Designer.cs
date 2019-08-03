namespace DuplicationsManager
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_checkFolder = new System.Windows.Forms.TextBox();
            this.button_checkFloder = new System.Windows.Forms.Button();
            this.label_checkFolderTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_checkFolder
            // 
            this.textBox_checkFolder.Location = new System.Drawing.Point(13, 47);
            this.textBox_checkFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_checkFolder.Name = "textBox_checkFolder";
            this.textBox_checkFolder.Size = new System.Drawing.Size(316, 20);
            this.textBox_checkFolder.TabIndex = 1;
            // 
            // button_checkFloder
            // 
            this.button_checkFloder.Location = new System.Drawing.Point(330, 47);
            this.button_checkFloder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_checkFloder.Name = "button_checkFloder";
            this.button_checkFloder.Size = new System.Drawing.Size(62, 20);
            this.button_checkFloder.TabIndex = 2;
            this.button_checkFloder.Text = "...";
            this.button_checkFloder.UseVisualStyleBackColor = true;
            // 
            // label_checkFolderTitle
            // 
            this.label_checkFolderTitle.AutoSize = true;
            this.label_checkFolderTitle.Location = new System.Drawing.Point(14, 29);
            this.label_checkFolderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkFolderTitle.Name = "label_checkFolderTitle";
            this.label_checkFolderTitle.Size = new System.Drawing.Size(70, 13);
            this.label_checkFolderTitle.TabIndex = 3;
            this.label_checkFolderTitle.Text = "Check folder:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_checkFolderTitle);
            this.Controls.Add(this.button_checkFloder);
            this.Controls.Add(this.textBox_checkFolder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(400, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_checkFolder;
        private System.Windows.Forms.Button button_checkFloder;
        private System.Windows.Forms.Label label_checkFolderTitle;
    }
}
