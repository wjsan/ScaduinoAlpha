using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModernUI;

namespace ModernUI
{
    public partial class Menu : Panel
    {
        private System.Timers.Timer timerAnimation = new System.Timers.Timer();
        private int step = -1;

        public Color ButtonHideOnOnverColor { get; set; }
        public bool Hidden { get; set; } = false;
        public int SizeWhenHide {get; set;}
        public int SizeWhenShow { get; set;}

        public Menu()
        { 
            InitializeComponent();
            timerAnimation.Interval = 1;
            timerAnimation.Elapsed += TimerAnimation_Elapsed;
            SizeWhenShow = Width;
            SizeWhenHide = 0;
        }

        private void TimerAnimation_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if ((Width - (-step * 10)) > SizeWhenHide && (Width + (step * 10)) < SizeWhenShow)
            {
                Invoke((MethodInvoker)delegate
               {
                   Width += step * 10;
               });
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    Width += step;
                });

            }
            if (Width == SizeWhenHide || Width == SizeWhenShow)
            {
                timerAnimation.Stop();
            }
        }

        private void Menu_ControlAdded(object sender, ControlEventArgs e)
        {
            if (typeof(MenuItem).IsInstanceOfType(e.Control))
            {
                e.Control.Dock = DockStyle.Top;
            }
        }

        public void HideMenu()
        {
            if (Hidden) return;
            step = -1;
            Width += step;
            timerAnimation.Start();
            Hidden = true;
        }

        public void ShowMenu()
        {
            if (!Hidden) return;
            step = 1;
            Width += step;
            timerAnimation.Start();
            Hidden = false;
        }

        public void ToggleMenu()
        {
            if (Hidden) ShowMenu();
            else HideMenu();
        }

        private void Menu_ParentChanged(object sender, EventArgs e)
        {
            if (Disposing || IsDisposed || BackColor != Color.Transparent) return;
            if(DesignMode)
                BackColor = Parent.BackColor;
        }

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            if(DesignMode)
                SizeWhenShow = Width;
        }
    }
}
