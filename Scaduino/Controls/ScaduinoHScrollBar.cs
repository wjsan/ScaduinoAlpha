using Scaduino.Components;
using Scaduino.Protocols;
using Scaduino.Windows;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public partial class ScaduinoHScrollBar : HScrollBar, IScaduinoControl
    {
        private CommunicationChannels communicationSource;
        private Tag tag;

        /// <summary>
        /// Collection of communication channels to be used for this controller
        /// </summary>
        [Description("Collection of communication channels to be used for this controller")]
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
                    Value = tag.Value;
                });
            }
        }

        /// <summary>
        /// Name of Tag linked to this controller
        /// </summary>
        [Description("Name of Tag linked to this controller")]
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        public string TagName { get => Tag.Name; }

        public ScaduinoHScrollBar()
        {
            ValueChanged += ScaduinoScrollBar_ValueChanged;
            InitializeComponent();
        }

        private void ScaduinoScrollBar_ValueChanged(object sender, System.EventArgs e)
        {
            tag.Value = Value;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
