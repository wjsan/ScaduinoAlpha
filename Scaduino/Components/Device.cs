using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scaduino.Components
{
    public partial class Device : Component
    {
        private BqBusNet.BqBus bqBus = new BqBusNet.BqBus();

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public BqBusNet.BqBus BqBus { get => bqBus; }

        [Category("Scaduino")]
        [Description("Controllers of this device.")]
        public List<Control> Controls { get; }

        public Device()
        {
            InitializeComponent();
            Controls = new List<Control>();
        }

        public Device(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public void Connect()
        {
            bqBus.Connect();
        }

        public void Disconnect()
        {
            bqBus.Disconnect();
        }

        public void AddControl(Control control)
        {
            Controls.Add(control);
            bqBus.Size = Controls.Count;
        }

        public void RemoveControl(Control control)
        {
            Controls.Remove(control);
            bqBus.Size = Controls.Count;
        }
    }
}
