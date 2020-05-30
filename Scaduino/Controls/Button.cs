using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scaduino.Components;
using System.ComponentModel.Design;

namespace Scaduino.Controls
{
    [Serializable]
    public partial class Button : ModernUI.Button
    {
        private Device device;

        [Category("Scaduino")]
        [Description("Device, which will read this component")]
        public Device Device 
        { 
            get => device;
            set 
            {
                device?.RemoveControl(this);
                device = value;
                device?.AddControl(this);
            } 
        }

        public Pin Pin { get; set; }

        public Button()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (device == null) return;
            int address = device.Controls.IndexOf(this);
            Device?.BqBus.SetReg(address, 1);
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (device == null) return;
            int address = device.Controls.IndexOf(this);
            Device?.BqBus.SetReg(address, 0);
        }

    }
}
