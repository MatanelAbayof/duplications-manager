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
    public partial class DupResultsForm : Form
    {

        public DupResultsForm(List<DupFiles> dupsFiles)
        {
            InitializeComponent();

            BuildDupFilesList(dupsFiles);
        }

        private void BuildDupFilesList(List<DupFiles> dupsFiles)
        {
            verticalListView_results.Controls.Clear();

            label_dupResTitle.Text = "Found " + dupsFiles.Count + " duplications:";

            foreach (DupFiles df in dupsFiles)
            {
                DupResult dupResult = new DupResult();
                dupResult.NumOfDups = df.DuplicationsFiles.Count;

                dupResult.AddOnHandleBtClickListener((s, e) =>
                {
                    DupMatchsForm dmf = new DupMatchsForm(df);
                    dmf.ShowDialog();
                });

                verticalListView_results.AddControl(dupResult);
            }
        }
    }
}
