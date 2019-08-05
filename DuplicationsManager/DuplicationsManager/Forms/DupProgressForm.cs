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
    public partial class DupProgressForm : Form
    {
        private string checkFolderPath;

        public DupProgressForm(string checkFolderPath)
        {
            this.checkFolderPath = checkFolderPath;

            InitializeComponent();

            linkLabel_checkedFolder.Text = checkFolderPath;

            backgroundWorker_buildResults.WorkerReportsProgress = true;
            backgroundWorker_buildResults.WorkerSupportsCancellation = true;

            // start build results
            backgroundWorker_buildResults.RunWorkerAsync();
        }

        private void LinkLabel_checkedFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(checkFolderPath);
        }

        private void BackgroundWorker_buildResults_DoWork(object sender, DoWorkEventArgs e)
        {
            // -------------TODO-----------------------------------------------


            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void BackgroundWorker_buildResults_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_checkDirs.Value = e.ProgressPercentage;
        }

        private void Button_stopBuildResults_Click(object sender, EventArgs e)
        {
            backgroundWorker_buildResults.CancelAsync();
            Close();
        }

        private void BackgroundWorker_buildResults_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ReturnResAndClose();
        }

        // return result and close dialog
        private void ReturnResAndClose()
        {
            this.DialogResult = DialogResult.OK;
            // TODO update result member
            Close();
        }
    }
}
