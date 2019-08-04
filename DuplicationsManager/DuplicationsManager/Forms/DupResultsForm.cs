using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicationsManager.Forms
{
    public partial class DupResultsForm : Form
    {
        private string checkFolderPath;

        public DupResultsForm(string checkFolderPath)
        {
            this.checkFolderPath = checkFolderPath;

            InitializeComponent();

            linkLabel_checkedFolder.Text = checkFolderPath;
        }

        private void LinkLabel_checkedFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(checkFolderPath);
        }
    }
}
