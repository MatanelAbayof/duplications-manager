using DuplicationsManager.Duplications;
using DuplicationsManager.Forms;
using DuplicationsManager.Media.Duplications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DuplicationsManager.Duplications.MediaFileInfo;

namespace DuplicationsManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitMediaTypes();


            UpdateCheckBt();
        }

        // init media types
        private void InitMediaTypes()
        {
            var mediaTypes = Enum.GetValues(typeof(MediaType)).Cast<MediaType>();
            foreach(MediaType mediaType in mediaTypes)
            {
                string mediaTypeInfo = MediaFileInfo.GetMediaTypeInfo(mediaType);
                listBox_mediaType.Items.Add(mediaTypeInfo);
            }
            listBox_mediaType.SelectedIndex = 0;
        }

        // get selected media type
        private MediaType GetSelectedMediaType()
        {
            var mediaTypes = Enum.GetValues(typeof(MediaType)).Cast<MediaType>();
            return mediaTypes.ToArray()[listBox_mediaType.SelectedIndex];
        }


        // update check button
        private void UpdateCheckBt()
        {
            button_checkDupFiles.Enabled = IsInputsOK();
        }

        // check if inputs OK
        private bool IsInputsOK()
        {
            // get text
            string checkFolderInputStr = textBox_checkFolder.Text;
            // check if text is directory
            return Directory.Exists(checkFolderInputStr);
        }

        private void TextBox_checkFolder_TextChanged(object sender, EventArgs e)
        {
            UpdateCheckBt();
        }

        private void Button_browseCheckFolder_Click(object sender, EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            fd.SelectedPath = textBox_checkFolder.Text;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string checkFolderPath = fd.SelectedPath;
                textBox_checkFolder.Text = checkFolderPath;
            }
        }

        private void Button_checkDupFiles_Click(object sender, EventArgs e)
        {
            DupRequestInfo dri = new DupRequestInfo();
            dri.CheckedDir = textBox_checkFolder.Text;

            dri.MediaType = GetSelectedMediaType();
            dri.MediaSortType = MediaSortType.BY_SIZE; // TODO set value from field


            OpenDupResultsForm(dri);
        }

        // open duplications result form
        private void OpenDupResultsForm(DupRequestInfo dupRequestInfo)
        {
            DupProgressForm dupProgressForm = new DupProgressForm(dupRequestInfo);
            DialogResult dialogResult = dupProgressForm.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                // get result data
                List<DupFiles> dupsFiles = dupProgressForm.ResultDupFiles;


                // check if have duplications
                if (dupsFiles.Count > 0) 
                {
                    OpenDupResultsForm(dupsFiles);
                } else 
                {
                    string dialogTitle = "No duplications";
                    string dialogMessage = "Not found duplication files.";
                    DialogResult result = MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        // open duplications results form
        private void OpenDupResultsForm(List<DupFiles> dupsFiles)
        {
            DupResultsForm dupResultsForm = new DupResultsForm(dupsFiles);
            dupResultsForm.ShowDialog();
        }
    }
}
