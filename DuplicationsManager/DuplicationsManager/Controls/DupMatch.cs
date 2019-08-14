using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DuplicationsManager.Utils;
using WMPLib;
using System.Diagnostics;

namespace DuplicationsManager.Controls
{
    public partial class DupMatch : UserControl
    {
        private string FilePath { get; }

        public DupMatch(string filePath)
        {
            FilePath = filePath;

            InitializeComponent();

            LoadComponentInfo();
        }

        // load component info from file
        private void LoadComponentInfo()
        {
            if (!File.Exists(FilePath))
            {
                Enabled = false;
                return;
            }


            // read file info
            FileInfo fileInfo = new FileInfo(FilePath);
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia mediainfo = wmp.newMedia(FilePath);

            linkLabel_filePath.Text = FilePath;

            label_fileSize.Text = FileLengthFormatter.FormatFileLength(fileInfo.Length);
            label_fileLength.Text = mediainfo.durationString;
        }

        private void Button_openFile_Click(object sender, EventArgs e)
        {
            if(CheckExistsFile(FilePath))
                Process.Start(FilePath);
        }

        private void Button_openFolder_Click(object sender, EventArgs e)
        {
            string dirName = Path.GetDirectoryName(FilePath);
            if(Directory.Exists(dirName))
            {
                Process.Start(dirName); // TODO need to select file at file explorer
                
            } else
            {
                // show error dialog
                string dialogTitle = "Error";
                string dialogMessage = "The directory at '" + dirName + "' not exists";
                MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void Button_deleteFile_Click(object sender, EventArgs e)
        {
            if(CheckExistsFile(FilePath))
            {
                // show dialog
                string dialogTitle = "Delete file";
                string dialogMessage = "Are you sure you want to delete the file at '" + FilePath + "'?";
                DialogResult dialogResult = MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    File.Delete(FilePath);
                    Enabled = false; // disable self
                }
            }
        }

        // check if file exists. if not show error dialog. return true if exist
        private static bool CheckExistsFile(string filePath)
        {
            if(!File.Exists(filePath))
            {
                // show error dialog
                string dialogTitle = "Error";
                string dialogMessage = "The file at '" + filePath + "' not exists";
                MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
