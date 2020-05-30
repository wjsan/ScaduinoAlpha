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
    public partial class ScreenContainer : TabControl
    {
        public TabPage SelectedScreen
        {
            get => this.SelectedTab;
            set => this.SelectedTab = value;
        }

        public ScreenContainer()
        {
            InitializeComponent();
            this.Appearance = TabAppearance.FlatButtons;
            this.ItemSize = new Size(0, 1);
            this.SizeMode = TabSizeMode.Fixed;
        }

    }
}
