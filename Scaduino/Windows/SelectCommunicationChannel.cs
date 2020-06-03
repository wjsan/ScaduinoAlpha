using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scaduino.Windows
{
    public partial class SelectCommunicationChannel : Form
    {
        public CommunicationDriver Driver { get; set; }
        private CommunicationDriver[] drivers;
        public SelectCommunicationChannel()
        {
            InitializeComponent();
            drivers = GlobalData.SelectedCommunicationChannels.Drivers;
            if (drivers != null)
            {
                comboBoxCommunicationPort.Items.Clear();
                foreach (var item in drivers)
                {
                    comboBoxCommunicationPort.Items.Add(item.Name);
                }
            }
        }

        private void comboBoxCommunicationPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = comboBoxCommunicationPort.SelectedIndex;
            Driver = drivers[idx];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
