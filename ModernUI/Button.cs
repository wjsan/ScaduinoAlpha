using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModernUI
{
    [Serializable]
    public partial class Button : Label
    {

        private Color colorMouseLeave;

        public Color ColorMouseLeave
        {
            get => colorMouseLeave;
            set
            {
                colorMouseLeave = value;
                BackColor = value;
            }
        }

        public Color ForeColorMouseLeave { get; set; }
        public Color ColorMouseEnter { get; set; }
        public Color ForeColorMouseEnter { get; set; }
        public Color ColorOnClick { get; set; }
        public Color ForeColorOnClick { get; set; }

        public Button()
        {
            InitializeComponent();
            ForeColor = Color.Black;
            ForeColorMouseLeave = Color.Black;
            BackColor = Color.LightGray;
            ColorMouseLeave = Color.LightGray;
            ColorMouseEnter = Color.Gray;
            ForeColorMouseEnter = Color.White;
            ColorOnClick = Color.FromArgb(0xFF, 85, 85, 85);
            ForeColorOnClick = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            base.AutoSize = false;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = ColorOnClick;
            ForeColor = ForeColorOnClick;
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = ColorMouseEnter;
            ForeColor = ForeColorMouseEnter;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            BackColor = ColorMouseEnter;
            ForeColor = ForeColorMouseEnter;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            BackColor = ColorMouseLeave;
            ForeColor = ForeColorMouseLeave;
        }
    }
}
