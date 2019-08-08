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
            this.button_handleDups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_numOfDupsTitle
            // 
            this.label_numOfDupsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.label_numOfDups.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_numOfDups.AutoSize = true;
            this.label_numOfDups.Font = new System.Drawing.Font("Guttman-CourMir", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_numOfDups.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_numOfDups.Location = new System.Drawing.Point(264, 22);
            this.label_numOfDups.Name = "label_numOfDups";
            this.label_numOfDups.Size = new System.Drawing.Size(27, 27);
            this.label_numOfDups.TabIndex = 1;
            this.label_numOfDups.Text = "0";
            // 
            // button_handleDups
            // 
            this.button_handleDups.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_handleDups.Location = new System.Drawing.Point(1212, 11);
            this.button_handleDups.Name = "button_handleDups";
            this.button_handleDups.Size = new System.Drawing.Size(145, 45);
            this.button_handleDups.TabIndex = 2;
            this.button_handleDups.Text = "Handle";
            this.button_handleDups.UseVisualStyleBackColor = true;
            // 
            // DupResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.button_handleDups);
            this.Controls.Add(this.label_numOfDups);
            this.Controls.Add(this.label_numOfDupsTitle);
            this.Name = "DupResult";
            this.Size = new System.Drawing.Size(1372, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numOfDupsTitle;
        private System.Windows.Forms.Label label_numOfDups;
        private System.Windows.Forms.Button button_handleDups;
    }
}
