using Scaduino.Editors;
using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace Scaduino.Components
{
    public class Alarm
    {
        public enum AlarmState
        {
            Inactived,
            Actived,
            Acked
        }

        public enum AlarmType
        {
            High,
            Low,
            Exactly
        }

        private Tag tag;

        public event EventHandler AlarmActived;
        public event EventHandler AlarmAck;
        public event EventHandler AlarmInactived;

        /// <summary>
        /// Tag to be evaluated on this alarm
        /// </summary>
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        [Description("Tag to be evaluated on this alarm")]
        public Tag Tag
        {
            get => tag;
            set
            {
                tag = value;
                tag.TagValueChanged += Tag_TagValueChanged;
            }
        }

        /// <summary>
        /// Name of Tag linked to this pin
        /// </summary>
        [Description("Name of Tag linked to this pin")]
        public string TagName { get => Tag.Name; }

        /// <summary>
        /// Status of alarm
        /// </summary>
        [Description("Status of alarm")]
        [Browsable(false)]
        public AlarmState Status { get; set; }

        /// <summary>
        /// Type of alarm
        /// </summary>
        [Description("Type of alarm")]
        public AlarmType Type { get; set; }

        /// <summary>
        /// Activation date of this alarm
        /// </summary>
        [Browsable(false)]
        [Description("Activation date of this alarm")]
        public string Date { get; set; }

        /// <summary>
        /// Limit of Alarm
        /// </summary>
        [Description("Limit of Alarm")]
        public double Limit { get; set; }

        /// <summary>
        /// Message to be shown on alarm list, on alarm activaction
        /// </summary>
        [Description("Message to be shown on alarm list, on alarm activaction")]
        public string Message { get; set; }

        /// <summary>
        /// Checks if alarm was acknowledged
        /// </summary>
        [Description("Checks if alarm was acknowledged")]
        public bool Acknowledged { get; set; }

        private void Tag_TagValueChanged(object sender, EventArgs e)
        {
            AlarmState status;

            switch (Type)
            {
                case AlarmType.High:
                    status = Tag.Value > Limit ? AlarmState.Actived : AlarmState.Inactived;
                    break;
                case AlarmType.Low:
                    status = Tag.Value < Limit ? AlarmState.Actived : AlarmState.Inactived;
                    break;
                case AlarmType.Exactly:
                    status = Tag.Value == Limit ? AlarmState.Actived : AlarmState.Inactived;
                    break;
                default:
                    status = AlarmState.Inactived;
                    break;
            }

            if(status != Status)
            {
                if (Status == AlarmState.Acked && status == AlarmState.Actived) return;
                Status = status;
                switch (Status)
                {
                    case AlarmState.Inactived:
                        AlarmInactived?.Invoke(this, new EventArgs());
                        break;
                    case AlarmState.Actived:
                        Date = DateTime.Now.ToString();
                        Acknowledged = false;
                        AlarmActived?.Invoke(this, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
        }

        public void ClearEvents()
        {
            AlarmInactived = null;
            AlarmActived = null;
            AlarmAck = null;
        }

        public void Ack()
        {
            if(Status != AlarmState.Inactived)
            {
                Status = AlarmState.Acked;
            }
            Acknowledged = true;
            AlarmAck?.Invoke(this, new EventArgs());
        }
    }
}
