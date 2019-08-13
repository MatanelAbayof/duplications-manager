namespace DuplicationsManager.Forms
{
    partial class DupMatchsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DupMatchsForm));
            this.label_dupsTitle = new System.Windows.Forms.Label();
            this.verticalListView_dupMatchs = new DuplicationsManager.Controls.VerticalListView();
            this.SuspendLayout();
            // 
            // label_dupsTitle
            // 
            this.label_dupsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_dupsTitle.AutoSize = true;
            this.label_dupsTitle.Location = new System.Drawing.Point(733, 39);
            this.label_dupsTitle.Name = "label_dupsTitle";
            this.label_dupsTitle.Size = new System.Drawing.Size(136, 25);
            this.label_dupsTitle.TabIndex = 0;
            this.label_dupsTitle.Text = "Duplications:";
            // 
            // verticalListView_dupMatchs
            // 
            this.verticalListView_dupMatchs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalListView_dupMatchs.AutoScroll = true;
            this.verticalListView_dupMatchs.Location = new System.Drawing.Point(13, 88);
            this.verticalListView_dupMatchs.Name = "verticalListView_dupMatchs";
            this.verticalListView_dupMatchs.Size = new System.Drawing.Size(1611, 681);
            this.verticalListView_dupMatchs.TabIndex = 1;
            // 
            // DupMatchsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 781);
            this.Controls.Add(this.verticalListView_dupMatchs);
            this.Controls.Add(this.label_dupsTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "DupMatchsForm";
            this.Text = "DupMatchsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dupsTitle;
        private Controls.VerticalListView verticalListView_dupMatchs;
    }
}