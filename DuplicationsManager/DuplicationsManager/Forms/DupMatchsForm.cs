using DuplicationsManager.Controls;
using DuplicationsManager.Duplications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicationsManager.Forms
{
    public partial class DupMatchsForm : Form
    {
        public DupMatchsForm(DupFiles dupFiles)
        {
            InitializeComponent();
            LoadComponentInfo(dupFiles);
        }


        // load component info from file
        private void LoadComponentInfo(DupFiles dupFiles)
        {
            foreach(string filePath in dupFiles.DuplicationsFiles)
            {
                DupMatch dm = new DupMatch(filePath);
                verticalListView_dupMatchs.AddControl(dm);
            }
        }
    }
}
