﻿using DuplicationsManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicationsManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            updateCheckBt();

            // TODO remove this
            openDupResultsForm(@"C:\");
        }


        // update check button
        private void updateCheckBt()
        {
            button_checkDupFiles.Enabled = isInputsOK();
        }

        // check if inputs OK
        private bool isInputsOK()
        {
            // get text
            string checkFolderInputStr = textBox_checkFolder.Text;
            // check if text is directory
            return Directory.Exists(checkFolderInputStr);
        }

        private void TextBox_checkFolder_TextChanged(object sender, EventArgs e)
        {
            updateCheckBt();
        }

        private void Button_browseCheckFolder_Click(object sender, EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string checkFolderPath = fd.SelectedPath;
                textBox_checkFolder.Text = checkFolderPath;
            }
        }

        private void Button_checkDupFiles_Click(object sender, EventArgs e)
        {
            openDupResultsForm(textBox_checkFolder.Text);
        }

        // open duplications result form
        private void openDupResultsForm(string checkFolderPath)
        {
            DupResultsForm dupResForm = new DupResultsForm(checkFolderPath);
            dupResForm.ShowDialog();
        }
    }
}
