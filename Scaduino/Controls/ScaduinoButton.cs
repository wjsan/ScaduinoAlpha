using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scaduino.Components;
using System.ComponentModel.Design;
using Scaduino.Protocols;
using Scaduino.Windows;
using System.Drawing.Design;
using System.Windows.Markup;

namespace Scaduino.Controls
{
    [Serializable]
    public partial class ScaduinoButton : ModernUI.Button, IScaduinoControl
    {
        private ICommunicationDriver communicationLink;
        private Tag tag;

        public enum ButtonMode
        {
            Pulse,
            TurnOn,
            TurnOff,
            Toggle
        }

        public ButtonMode Mode { get; set; }

        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        new public Tag Tag 
        { 
            get
            {
                if (communicationLink != null)
                    Editors.SelectTag.Tags = communicationLink.Tags;
                return tag; 
            }
            set
            {
                tag = value;
                Editors.SelectTag.SelectedTag = tag;
            }
        }

        public ICommunicationDriver CommunicationLink
        {
            get => communicationLink;
            set
            {
                communicationLink = value;
                if(communicationLink != null)
                    Editors.SelectTag.Tags = communicationLink.Tags;
            }
        }

        public ScaduinoButton()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case ButtonMode.Pulse:
                    communicationLink.SetReg(Tag.getAddress(), 1);
                    break;
                case ButtonMode.TurnOn:
                    communicationLink.SetReg(Tag.getAddress(), 1);
                    break;
                case ButtonMode.TurnOff:
                    communicationLink.SetReg(Tag.getAddress(), 0);
                    break;
                case ButtonMode.Toggle:
                    communicationLink.ToggleReg(Tag.getAddress());
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
                    communicationLink.SetReg(Tag.getAddress(), 0);
                    break;
                case ButtonMode.TurnOn:
                    communicationLink.SetReg(Tag.getAddress(), 1);
                    break;
                case ButtonMode.TurnOff:
                    communicationLink.SetReg(Tag.getAddress(), 0);
                    break;
                case ButtonMode.Toggle:
                    break;
                default:
                    break;
            }
        }

    }
}
