using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using ModernUI;

namespace ModernUI
{
    [Serializable]
    public partial class MenuItem : UserControl
    {
        private bool selected;
        private Color colorMouseLeave;
        private bool autoColors;

        [Localizable(true), Browsable(true)]
        public string LabelText
        {
            get
            {
                return labelMenu.Text.Trim();
            }

            set
            {
                if (Image != null) value = "          " + value;
                labelMenu.Text = value;
            }
        }

        public Image Image
        {
            get
            {
                return labelMenu.Image;
            }

            set
            {
                labelMenu.Image = value;
                LabelText = LabelText;
            }
        }
        public ScreenContainer ScreenContainer { get; set; }
        public Screen Screen { get; set; }

        public bool ExitApplication { get; set; }

        public Color ColorMouseLeave
        {
            get => colorMouseLeave;
            set
            {
                colorMouseLeave = value;
                BackColor = value;
            }
        }

        public bool AutoColors { 
            get => autoColors; 
            set
            {
                autoColors = value;
                AdjustColors();
            }
        }

        public Color ColorMouseEnter { get; set; }
        public Color ColorSelected { get; set; }
        public Color ColorOnClick { get; set; }
        public Color ColorSelectedIndicator { get => labelSelected.BackColor; set => labelSelected.BackColor = value; }
        public ContentAlignment TextAlign { get => labelMenu.TextAlign; set => labelMenu.TextAlign = value; }
        public bool Selected
        {
            get => selected;
            set
            {
                selected = value;
                BackColor = selected ? ColorSelected : ColorMouseLeave;
                labelSelected.Visible = selected;
            }
        }

        public delegate void MenuItemEventArgs(object sender, EventArgs eventArgs);

        public event MenuItemEventArgs MenuItemClicked;

        public MenuItem()
        {
            InitializeComponent();
        }

        private void LabelMenu_Click(object sender, EventArgs e)
        {
            MenuItemClicked?.Invoke(this, e);
            foreach (Control control in Parent.Controls)
            {
                if (control.GetType() == this.GetType())
                {
                    var menuItem = (MenuItem)control;
                    menuItem.Selected = false;
                }
            }
            this.Selected = true;
            if(ScreenContainer != null)
            {
                try
                {
                    ScreenContainer.SelectedScreen = Screen;

                }
                catch (Exception)
                {

                }
            }
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = ColorMouseEnter;
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Selected ? ColorSelected : ColorMouseLeave;
        }

        private void MenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = ColorOnClick;
            if (ExitApplication)
                Application.Exit();
        }

        private void MenuItem_ForeColorChanged(object sender, EventArgs e)
        {
            labelMenu.ForeColor = this.ForeColor;
        }

        private void MenuItem_FontChanged(object sender, EventArgs e)
        {
            labelMenu.Font = this.Font;
        }

        private void AdjustColors()
        {
            if (Parent != null && autoColors)
            {
                var c = Parent.BackColor;
                ColorMouseLeave = c;
                ColorSelected = c;
                ForeColor = Parent.ForeColor;
                Font = Parent.Font;
                ColorMouseEnter = Color.FromArgb(255, getColor(c.R, 10), getColor(c.G, 10), getColor(c.B, 10));
                ColorOnClick = Color.FromArgb(255, getColor(c.R, 25), getColor(c.G, 25), getColor(c.B, 25));
            }
        }

        private int getColor(int color, int offset)
        {
            if (color + offset < 255) return color + offset;
            else return color - offset;
        }
    }
}
