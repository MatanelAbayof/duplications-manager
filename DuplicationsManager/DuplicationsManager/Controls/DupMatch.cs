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

namespace DuplicationsManager.Controls
{
    public partial class DupMatch : UserControl
    {
        public DupMatch(string filePath)
        {
            InitializeComponent();

            LoadComponentInfo(filePath);
        }

        // load component info from file
        private void LoadComponentInfo(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            linkLabel_filePath.Text = filePath;

            // TODO update views
        }
    }
}
