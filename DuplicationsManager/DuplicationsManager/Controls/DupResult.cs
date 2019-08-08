using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicationsManager.Controls
{
    public partial class DupResult : UserControl
    {
        private int numOfDups;
        public int NumOfDups
        {
            get { return numOfDups; }
            set
            {
                this.numOfDups = value;
                this.label_numOfDups.Text = value.ToString();
            }
        }

        public DupResult()
        {
            InitializeComponent();
        }

        public void AddOnHandleBtClickListener(EventHandler eh)
        {
            button_handleDups.Click += eh;
        }
    }
}
