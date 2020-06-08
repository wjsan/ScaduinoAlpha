using Scaduino.Components;
using Scaduino.Protocols;
using Scaduino.Editors;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public partial class ScaduinoNumericTextBox : TextBox, IScaduinoControl
    {
        private CommunicationChannels communicationSource;
        private Tag tag;

        /// <summary>
        /// Collection of communication channels to be used for this controller
        /// </summary>
        [Description("Collection of communication channels to be used for this controller")]
        [Category("Scaduino")]
        public CommunicationChannels CommunicationSource
        {
            get
            {
                GlobalData.SelectedCommunicationChannels = communicationSource;
                return communicationSource;
            }
            set => communicationSource = value;
        }

        /// <summary>
        /// Tag linked to this controller
        /// </summary>
        [Description("Tag linked to this controller")]
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        [Category("Scaduino")]
        new public Tag Tag
        {
            get => tag;
            set
            {
                tag = value;
                tag.TagValueChanged += Tag_TagValueChanged;
            }
        }

        private void Tag_TagValueChanged(object sender, System.EventArgs e)
        {
            if (Created)
            {
                Invoke((MethodInvoker)delegate {
                    Text = tag.Value.ToString();
                });
            }
        }

        /// <summary>
        /// Name of Tag linked to this controller
        /// </summary>
        [Description("Name of Tag linked to this controller")]
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        [Category("Scaduino")]
        public string TagName { get => Tag.Name; }

        public ScaduinoNumericTextBox()
        {
            TextChanged += ScaduinoTextBox_ValueChanged;
            KeyPress += ScaduinoNumericTextBox_KeyPress;
            InitializeComponent();
        }

        private void ScaduinoNumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ScaduinoTextBox_ValueChanged(object sender, System.EventArgs e)
        {
            tag.Value = int.Parse(Text);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
