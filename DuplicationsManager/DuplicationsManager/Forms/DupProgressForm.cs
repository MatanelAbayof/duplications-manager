using DuplicationsManager.Duplications;
using DuplicationsManager.Media.Duplications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicationsManager.Forms
{
    public partial class DupProgressForm : Form
    {
        private DupRequestInfo dupRequestInfo;
        public List<DupFiles> ResultDupFiles;

        public DupProgressForm(DupRequestInfo dupRequestInfo)
        {
            this.dupRequestInfo = dupRequestInfo;

            InitializeComponent();

            linkLabel_checkedFolder.Text = dupRequestInfo.CheckedDir;

            backgroundWorker_buildResults.WorkerReportsProgress = true;
            backgroundWorker_buildResults.WorkerSupportsCancellation = true;

            // start build results
            backgroundWorker_buildResults.RunWorkerAsync();
        }

        private void LinkLabel_checkedFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(dupRequestInfo.CheckedDir);
        }

        private void BackgroundWorker_buildResults_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            ResultDupFiles = DupManager.CheckDup(dupRequestInfo); // update result member

            // TODO add worker.ReportProgress(i * 10);
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
            Close();
        }
    }
}
