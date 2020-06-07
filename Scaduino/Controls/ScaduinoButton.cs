using System;
using System.ComponentModel;
using System.Windows.Forms;
using Scaduino.Components;
using Scaduino.Protocols;
using Scaduino.Windows;
using System.Drawing.Design;

namespace Scaduino.Controls
{
    public partial class ScaduinoButton : ModernUI.Button, IScaduinoControl
    {
        public enum ButtonMode
        {
            Pulse,
            TurnOn,
            TurnOff,
            Toggle
        }

        private CommunicationChannels communicationSource;

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
        /// Operation mode of this button
        /// </summary>
        [Description("Operation mode of this button")]
        public ButtonMode Mode { get; set; }

        /// <summary>
        /// Tag linked to this controller
        /// </summary>
        [Description("Tag linked to this controller")]
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        new public Tag Tag { get; set; }

        /// <summary>
        /// Name of Tag linked to this controller
        /// </summary>
        [Description("Name of Tag linked to this controller")]
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        public string TagName { get => Tag.Name; }

        public ScaduinoButton()
        {
            InitializeComponent();
            communicationSource = GlobalData.SelectedCommunicationChannels;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case ButtonMode.Pulse:
                    Tag.Value = 1;
                    break;
                case ButtonMode.TurnOn:
                    Tag.Value = 1;
                    break;
                case ButtonMode.TurnOff:
                    Tag.Value = 0;
                    break;
                case ButtonMode.Toggle:
                    Tag.Value = Tag.Value == 1 ? 0 : 1;
                    break;
                default:
                    break;
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case ButtonMode.Pulse:
                    Tag.Value = 0;
                    break;
                case ButtonMode.TurnOn:
                    Tag.Value = 1;
                    break;
                case ButtonMode.TurnOff:
                    Tag.Value = 0;
                    break;
                case ButtonMode.Toggle:
                    break;
                default:
                    break;
            }
        }

    }
}
