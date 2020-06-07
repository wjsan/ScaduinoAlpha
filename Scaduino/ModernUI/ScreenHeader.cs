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
    public partial class ScreenHeader : Label
    {
        private ScreenContainer screenContainer;

        public ScreenContainer ScreenContainer 
        { 
            get => screenContainer;
            set 
            {
                screenContainer = value;
                if(screenContainer != null)
                {
                    screenContainer.SelectedScreenChanged -= Screen_SelectedScreenChanged;
                    screenContainer = value;
                    screenContainer.SelectedScreenChanged += Screen_SelectedScreenChanged;
                }
            }
        }

        private void Screen_SelectedScreenChanged(object sender, EventArgs e)
        {
            if (screenContainer != null && screenContainer.SelectedScreen != null)
            {
                if (screenContainer.SelectedScreen.HeaderText != null)
                    Text = screenContainer.SelectedScreen.HeaderText;
            }
        }

        public ScreenHeader()
        {
            InitializeComponent();
        }

        private void ScreenHeader_Paint(object sender, PaintEventArgs e)
        {
            AutoSize = false;
        }
    }
}
