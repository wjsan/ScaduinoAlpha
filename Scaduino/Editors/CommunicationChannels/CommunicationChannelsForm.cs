using Scaduino.Components;
using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scaduino.Editors
{
    public partial class CommunicationChannelsForm : Form
    {
        public List<CommunicationDriver> Drivers { get; set; }
        private CommunicationDriver driver;

        public CommunicationChannelsForm()
        {
            InitializeComponent();
        }

        private void CommunicationLinksForm_Load(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxDriveType.Items.Count > 0)
                    comboBoxDriveType.SelectedIndex = 0;
                if(listBoxCommunicationLinks.Items.Count > 0)
                    listBoxCommunicationLinks.SelectedIndex = 0;
                if(GlobalData.SelectedCommunicationChannels.Drivers != null)
                Drivers = GlobalData.SelectedCommunicationChannels.Drivers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            RenderCommunicationList();
        }

        private void RenderCommunicationList()
        {
            if (Drivers == null) return;
            listBoxCommunicationLinks.Items.Clear();
            foreach (var driver in Drivers)
            {
                listBoxCommunicationLinks.Items.Add(driver.Name);
            }
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            try
            {
                if (Drivers == null)
                {
                    Drivers = new List<CommunicationDriver>();
                }
                else
                {
                    Drivers = Drivers.ToList();
                }
                if (CheckDriverExists(comboBoxDriveType.SelectedItem.ToString()))
                {
                    MessageBox.Show($"Driver {comboBoxDriveType.SelectedItem.ToString()} already exists. Change driver name and try again.");
                    return;
                }
                switch (comboBoxDriveType.SelectedIndex)
                {
                    case 0:
                        var newDrive = new Protocols.BqBus.BqBusSerialDriver();
                        Drivers.Add(newDrive);
                        break;
                    default:
                        break;
                }
                RenderCommunicationList();
                listBoxCommunicationLinks.SelectedIndex = listBoxCommunicationLinks.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void buttonRemoveLink_Click(object sender, EventArgs e)
        {

        }

        bool CheckDriverExists(string name)
        {
            foreach (string item in listBoxCommunicationLinks.Items)
            {
                if(item == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonDeleteTag_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listBoxCommunicationLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBoxCommunicationLinks.SelectedIndex;
            driver = Drivers[idx];
            commProperties.SelectedObject = driver;
        }

        private void commProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            RenderCommunicationList();
        }

        private void listBoxCommunicationLinks_KeyDown(object sender, KeyEventArgs e)
        {
            var result = MessageBox.Show(
                "All tags of this driver will be losted. Continue?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (listBoxCommunicationLinks.SelectedIndex >= 0)
                {
                    if(e.KeyCode == Keys.Delete)
                    {
                        int idx = listBoxCommunicationLinks.SelectedIndex;
                        Drivers.RemoveAt(idx);
                        RenderCommunicationList();
                    }
                }
            }
        }
    }
}
