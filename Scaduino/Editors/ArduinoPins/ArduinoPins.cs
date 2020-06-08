using Scaduino.ArduinoBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.UI.Design.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Scaduino.Editors
{
    public partial class ArduinoPins : Form
    {
        public List<Pin> Pins { get; set; }
        private Pin pin;

        public ArduinoPins(Pin[] pins)
        {
            InitializeComponent();
            if(pins == null)
            {
                Pins = new List<Pin>();
            }
            else
            {
                Pins = pins.ToList();
                RenderPinsList();
            }
        }

        private void RenderPinsList()
        {
            listBoxPins.Items.Clear();
            try
            {
                foreach (var pin in Pins)
                {
                    listBoxPins.Items.Add(pin.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pins.Add(new Pin()
            { 
                Name = $"pin{Pins.Count+1}",
                Number = Pins.Count + 2
            });
            RenderPinsList();
            try
            {
                listBoxPins.SelectedIndex = listBoxPins.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void listBoxPins_SelectedIndexChanged(object sender, EventArgs e)
        {
            pin = Pins[listBoxPins.SelectedIndex];
            pinProperties.SelectedObject = pin;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new SelectTag();
                var dialog = form.ShowDialog();
                if (dialog == DialogResult.OK)
                    pin.Tag = form.SelectedTag;
                pinProperties.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pinProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            RenderPinsList();
        }
    }
}
