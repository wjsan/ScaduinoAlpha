using Scaduino.Components;
using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scaduino.Windows
{
    public partial class CommunicationChannelsForm : Form
    {
        public CommunicationDriver[] Drivers { get; set; }
        private CommunicationDriver driver;

        public CommunicationChannelsForm()
        {
            InitializeComponent();
        }

        private void CommunicationLinksForm_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxDriveType.SelectedIndex = 0;
                listBoxCommunicationLinks.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
            Drivers = GlobalData.SelectedCommunicationChannels.Drivers;
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
                List<CommunicationDriver> list;
                if (Drivers == null)
                {
                    list = new List<CommunicationDriver>();
                }
                else
                {
                    list = Drivers.ToList();
                }
                if (CheckDriverExists(comboBoxDriveType.SelectedItem.ToString()))
                {
                    return;
                }
                switch (comboBoxDriveType.SelectedIndex)
                {
                    case 0:
                        var newDrive = new BqBusSerialDriver();
                        list.Add(newDrive);
                        break;
                    default:
                        break;
                }
                Drivers = list.ToArray();
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
    }
}
