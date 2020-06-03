using Scaduino.Windows;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Scaduino.Protocols
{
    public partial class CommunicationChannels : Component
    {
        private CommunicationDriver[] drivers;

        /// <summary>
        /// Drivers list of this collection
        /// </summary>
        [Description("Drivers list of this collection")]
        [Editor(typeof(CommunicationChannelsEditor), typeof(UITypeEditor))]
        public CommunicationDriver[] Drivers
        {
            get
            {
                GlobalData.SelectedCommunicationChannels = this;
                return drivers;
            }
            set => drivers = value;
        }

        public CommunicationChannels(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
