namespace DuplicationsManager.Controls
{
    partial class DupResult
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
            this.label_numOfDupsTitle = new System.Windows.Forms.Label();
            this.label_numOfDups = new System.Windows.Forms.Label();
            this.verticalListView_dupMatchs = new DuplicationsManager.Controls.VerticalListView();
            this.SuspendLayout();
            // 
            // label_numOfDupsTitle
            // 
            this.label_numOfDupsTitle.AutoSize = true;
            this.label_numOfDupsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_numOfDupsTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_numOfDupsTitle.Location = new System.Drawing.Point(22, 22);
            this.label_numOfDupsTitle.Name = "label_numOfDupsTitle";
            this.label_numOfDupsTitle.Size = new System.Drawing.Size(227, 25);
            this.label_numOfDupsTitle.TabIndex = 0;
            this.label_numOfDupsTitle.Text = "Num of duplications:";
            // 
            // label_numOfDups
            // 
            this.label_numOfDups.AutoSize = true;
            this.label_numOfDups.Font = new System.Drawing.Font("Guttman-CourMir", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_numOfDups.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_numOfDups.Location = new System.Drawing.Point(246, 22);
            this.label_numOfDups.Name = "label_numOfDups";
            this.label_numOfDups.Size = new System.Drawing.Size(27, 27);
            this.label_numOfDups.TabIndex = 1;
            this.label_numOfDups.Text = "0";
            // 
            // verticalListView_dupMatchs
            // 
            this.verticalListView_dupMatchs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalListView_dupMatchs.AutoScroll = true;
            this.verticalListView_dupMatchs.Location = new System.Drawing.Point(15, 68);
            this.verticalListView_dupMatchs.Name = "verticalListView_dupMatchs";
            this.verticalListView_dupMatchs.Size = new System.Drawing.Size(1340, 170);
            this.verticalListView_dupMatchs.TabIndex = 2;
            // 
            // DupResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.verticalListView_dupMatchs);
            this.Controls.Add(this.label_numOfDups);
            this.Controls.Add(this.label_numOfDupsTitle);
            this.Name = "DupResult";
            this.Size = new System.Drawing.Size(1372, 259);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numOfDupsTitle;
        private System.Windows.Forms.Label label_numOfDups;
        private VerticalListView verticalListView_dupMatchs;
    }
}
