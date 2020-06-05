using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class ScreenTopBar : Panel
    {
        public ScreenTopBar()
        {
            InitializeComponent();
        }

        private void ScreenTopBar_ParentChanged(object sender, EventArgs e)
        {
            if(Parent != null)
            {
                Dock = DockStyle.Top;
                BackColor = Parent.BackColor; 
            }
        }

        private void ScreenTopBar_ControlAdded(object sender, ControlEventArgs e)
        {
            if (DesignMode)
            {
                e.Control.Dock = DockStyle.Left;
                e.Control.BackColor = BackColor;
            }
        }
    }
}
