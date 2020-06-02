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
    }
}
