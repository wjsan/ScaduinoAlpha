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

        public Color BackColorOnOver
        {
            get => colorOnOver;
            set 
            {
                colorOnOver = value;
                backColor = BackColor;
            }
        }

        public Menu Menu { get; set; }
        public HideMenu()
        {
            InitializeComponent();
        }

        private void HideMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Menu?.ToggleMenu();
            if (Menu != null)
            {
                Text = Menu.Hidden ? ">" : "<";
            }
        }

        private void HideMenu_Paint(object sender, PaintEventArgs e)
        {
            AutoSize = false;
            Text = Text;
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
            if(Parent != null)
            {
                if (typeof(Menu).IsInstanceOfType(this.Parent))
                    Menu = (Menu)Parent;
                else
                    Parent.Controls.Remove(this);
            }
            this.SendToBack();
            Parent.ControlAdded += Parent_ControlAdded;
        }

        private void Parent_ControlAdded(object sender, ControlEventArgs e)
        {
            this.SendToBack();
        }
    }
}
