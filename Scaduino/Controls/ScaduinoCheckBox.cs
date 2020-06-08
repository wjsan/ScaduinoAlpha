using Scaduino.Components;
using Scaduino.Protocols;
using Scaduino.Editors;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public partial class ScaduinoCheckBox : CheckBox, IScaduinoControl
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
        [Category("Scaduino")]
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


        /// <summary>
        /// Name of Tag linked to this controller
        /// </summary>
        [Description("Name of Tag linked to this controller")]
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        [Category("Scaduino")]
        public string TagName { get => Tag.Name; }
        public ScaduinoCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void Tag_TagValueChanged(object sender, System.EventArgs e)
        {
            if (Created)
            {
                Invoke((MethodInvoker)delegate{
                    Checked = tag.Value == 1;
                });
            }
        }

        private void ScaduinoCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Tag.Value = Checked ? 1 : 0;
        }
    }
}
