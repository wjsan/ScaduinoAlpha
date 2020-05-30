﻿using System;
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
        private ScreenContainer screenController;

        public ScreenContainer ScreenController 
        { 
            get => screenController;
            set 
            {
                screenController = value;
                if(screenController != null)
                {
                    screenController.SelectedIndexChanged -= Screen_SelectedIndexChanged;
                    screenController = value;
                    screenController.SelectedIndexChanged += Screen_SelectedIndexChanged;
                }
            }
        }

        private void Screen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (screenController != null)
            {
                Text = screenController.SelectedTab.Text;
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
