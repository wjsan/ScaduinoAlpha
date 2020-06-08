using Scaduino.Components;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    [ToolboxItem(false)]
    public partial class AlarmItem : UserControl
    {

        new public event EventHandler DoubleClick;

        public Image StatusImage { get => pictureBoxStatus.Image; set => pictureBoxStatus.Image = value; }
        public string Date { get => labelDate.Text; set => labelDate.Text = value; }
        public string TagName { get => labelTagName.Text; set => labelTagName.Text = value; }
        public string Message { get => labelMessage.Text; set => labelMessage.Text = value; }
        public Alarm MyAlarm { get; set; }

        public AlarmItem()
        {
            InitializeComponent();
        }

        private void AlarmItem_DoubleClick(object sender, System.EventArgs e)
        {
            DoubleClick?.Invoke(this, e);
            MyAlarm?.Ack();
        }

        public void ClearEvents()
        {
            DoubleClick = null;
        }

        private void AlarmItem_ForeColorChanged(object sender, EventArgs e)
        {
            labelDate.ForeColor = ForeColor;
            labelTagName.ForeColor = ForeColor;
            labelMessage.ForeColor = ForeColor;
        }
    }
}
