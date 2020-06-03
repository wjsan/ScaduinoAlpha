using Scaduino.Components;
using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Scaduino.Windows
{
    public partial class SelectTag : Form
    {
        private CommunicationDriver[] driversSheet;
        private Tag[] Tags { get; set; }
        public Tag SelectedTag { get; set; }

        public SelectTag()
        {
            InitializeComponent();
            driversSheet = GlobalData.SelectedCommunicationChannels.Drivers;
        }

        private void SelectTag_Load(object sender, EventArgs e)
        {
            if (driversSheet == null) return;
            foreach (var driver in driversSheet)
            {
                comboBoxCommunicationLink.Items.Add(driver.Name);
            }
            try
            {
                comboBoxCommunicationLink.SelectedIndex = 0;
                comboBoxTags.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void comboBoxCommunicationLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (driversSheet == null) return;
            Tags = driversSheet[comboBoxCommunicationLink.SelectedIndex].Tags;
            foreach (var tag in Tags)
            {
                comboBoxTags.Items.Add(tag.Name);
            }
        }

        private void comboBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTags.SelectedItem != null)
                SelectedTag = Tags[comboBoxTags.SelectedIndex];
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
