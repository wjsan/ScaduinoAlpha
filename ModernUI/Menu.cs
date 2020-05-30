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
        private int previousSize = 0;

        public Color ButtonHideOnOnverColor { get ; set; }
        public bool Hidden { get; set; } = false;

        public Menu()
        { 
            InitializeComponent();
            timerAnimation.Interval = 1;
            timerAnimation.Elapsed += TimerAnimation_Elapsed;
            previousSize = this.Width;
        }

        private void TimerAnimation_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.Width > 20 && (this.Width + 10) < previousSize)
            {
                this.Invoke((MethodInvoker)delegate
               {
                   this.Width += step * 10;
               });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Width += step;
                });

            }
            if (this.Width == 10 || this.Width == previousSize)
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
            previousSize = this.Width;
            step = -1;
            this.Width += step;
            timerAnimation.Start();
            Hidden = true;
        }

        public void ShowMenu()
        {
            if (!Hidden) return;
            step = 1;
            this.Width += step;
            timerAnimation.Start();
            Hidden = false;
        }

        public void ToggleMenu()
        {
            if (Hidden) ShowMenu();
            else HideMenu();
        }
    }
}
