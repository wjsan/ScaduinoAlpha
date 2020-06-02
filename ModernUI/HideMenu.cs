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
    public partial class HideMenu : Label
    {
        private Color backColor;
        private Color colorOnOver;
        private bool initialize = true;

        public Color BackColorOnOver
        {
            get => colorOnOver;
            set
            {
                colorOnOver = value;
                backColor = BackColor;
            }
        }

        public HideMenu()
        {
            InitializeComponent();
        }

        private void HideMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Menu menu = (Menu)Parent;
            menu?.ToggleMenu();
            if (menu != null)
            {
                Text = menu.Hidden ? ">" : "<";
            }
        }

        private void HideMenu_Paint(object sender, PaintEventArgs e)
        {
            if (initialize)
            {
                AutoSize = false;
                Text = "";
                initialize = false;
            }
        }

        private void HideMenu_MouseEnter(object sender, EventArgs e)
        {
            BackColor = BackColorOnOver;
        }

        private void HideMenu_MouseLeave(object sender, EventArgs e)
        {
            BackColor = backColor;
        }

        private void HideMenu_ParentChanged(object sender, EventArgs e)
        {
            if (Disposing || IsDisposed) return;
            if (Parent != null)
            {
                if (!typeof(Menu).IsInstanceOfType(this.Parent))
                {
                    Parent.Controls.Remove(this);
                    return;
                }
            }
            SendToBack();
            Parent.ControlAdded += Parent_ControlAdded;
        }

        private void Parent_ControlAdded(object sender, ControlEventArgs e)
        {
            SendToBack();
        }
    }
}
