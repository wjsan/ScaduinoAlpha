using Scaduino.Components;
using Scaduino.Protocols;
using Scaduino.Editors;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public partial class ScaduinoLabel : Label, IScaduinoControl
    {
        private CommunicationChannels communicationSource;
        private Tag tag;
        private LabelStyle[] styles;

        public LabelStyle[] Styles
        {
            get => styles;
            set
            {
                styles = value;
                if (styles != null)
                {
                    if (styles.Length > 0)
                    {
                        styles[0].StyleLabel(this);
                    }
                }
            }
        }

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
                Invoke((MethodInvoker)delegate
                {
                    int style = tag.Value;
                    if (style < Styles.Length)
                    {
                        Styles[style].StyleLabel(this);
                    }
                    else
                    {
                        Text = "Error";
                    }
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
        public ScaduinoLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
