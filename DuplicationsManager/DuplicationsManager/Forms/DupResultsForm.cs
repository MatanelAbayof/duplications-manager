using DuplicationsManager.Controls;
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
        public DupResultsForm()
        {
            InitializeComponent();

            setDummyListItems();
        }

        private void setDummyListItems()
        {
            for(int i = 0; i < 20; ++i)
            {
                DupResult dupResult = new DupResult();
                dupResult.NumOfDups = i;
                for(int j = 0; j < i; ++j)
                {
                    DupMatch dupMatch = new DupMatch();
                    dupResult.AddDupMatch(dupMatch);
                }
                verticalListView_results.AddControl(dupResult);
            }
            

        }
    }
}
