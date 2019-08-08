using DuplicationsManager.Controls;

namespace DuplicationsManager.Forms
{
    partial class DupResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DupResultsForm));
            this.label_dupResTitle = new System.Windows.Forms.Label();
            this.verticalListView_results = new DuplicationsManager.Controls.VerticalListView();
            this.SuspendLayout();
            // 
            // label_dupResTitle
            // 
            this.label_dupResTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_dupResTitle.AutoSize = true;
            this.label_dupResTitle.Font = new System.Drawing.Font("MS Outlook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_dupResTitle.Location = new System.Drawing.Point(276, 42);
            this.label_dupResTitle.Name = "label_dupResTitle";
            this.label_dupResTitle.Size = new System.Drawing.Size(242, 24);
            this.label_dupResTitle.TabIndex = 0;
            this.label_dupResTitle.Text = "Your duplications results:";
            // 
            // verticalListView_results
            // 
            this.verticalListView_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalListView_results.AutoScroll = true;
            this.verticalListView_results.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.verticalListView_results.Location = new System.Drawing.Point(21, 96);
            this.verticalListView_results.Name = "verticalListView_results";
            this.verticalListView_results.Size = new System.Drawing.Size(751, 823);
            this.verticalListView_results.TabIndex = 1;
            // 
            // DupResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 931);
            this.Controls.Add(this.label_dupResTitle);
            this.Controls.Add(this.verticalListView_results);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "DupResultsForm";
            this.Text = "Duplications results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dupResTitle;
        private VerticalListView verticalListView_results;
    }
}