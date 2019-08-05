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
    public partial class VerticalListView : UserControl
    {
        public VerticalListView()
        {
            InitializeComponent();
            this.ClientSizeChanged += HorizonalPanel_ClientSizeChanged;
        }

        private void HorizonalPanel_ClientSizeChanged(object sender, EventArgs e)
        {
            // update widths
            int controlSize = GetControlWidth();
            foreach (Control control in this.Controls)
            {
                // set max width
                control.Width = controlSize;
            }
        }

        private int GetControlWidth()
        {
            return this.Width - 20;
        }

        public void ClearAllControls()
        {
            this.Controls.Clear();
        }

        public void SetControls(Control[] controls)
        {
            ClearAllControls();

            foreach (Control control in controls)
            {
                AddControl(control);
            }
        }

        public void AddControl(Control control)
        {
            // find position
            int posY = 0;
            if (this.Controls.Count > 0)
            {
                // get last control
                Control lastC = this.Controls[this.Controls.Count - 1];
                // calc new position
                posY = lastC.Location.Y + lastC.Size.Height + 1;
            }
            // set new position
            control.Location = new Point(0, posY);

            // set max width
            control.Width = GetControlWidth();

            // add control
            this.Controls.Add(control);
        }
    }
}
