using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool hideTopBar;

        public bool HideTopBar
        {
            get => hideTopBar;
            set
            {
                hideTopBar = value;
                this.ControlBox = !value;
                if(value) this.Text = string.Empty;
                this.DoubleBuffered = value;
            }
        }

        public Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
