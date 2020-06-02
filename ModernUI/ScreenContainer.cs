using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class ScreenContainer : Panel
    {
        private Screen selectedScreen;
        private Control lastParent;

        public event EventHandler SelectedScreenChanged;

        public Screen[] Screens { get; set; }

        public Screen SelectedScreen
        {
            get => selectedScreen;
            set
            {
                selectedScreen = value;
                Controls.Clear();
                if(selectedScreen != null)
                {
                    Controls.Add(selectedScreen);
                    selectedScreen.Dock = DockStyle.Fill;
                    SelectedScreenChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public ScreenContainer()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void ScreenContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!typeof(Screen).IsInstanceOfType(e.Control))
            {
                MessageBox.Show("Need to be Screen controller");
                Controls.Remove(e.Control);
            }
        }

        private void ScreenContainer_ParentChanged(object sender, EventArgs e)
        {
            if (lastParent != null)
                lastParent.ControlRemoved -= Parent_ControlRemoved;
            if (Parent != null)
            {
                Parent.ControlRemoved += Parent_ControlRemoved;
                lastParent = Parent;
            }
        }

        private void Parent_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control == this)
            {
                
            }
        }
    }
}
