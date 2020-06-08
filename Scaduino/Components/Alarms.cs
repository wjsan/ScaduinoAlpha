using System;
using System.ComponentModel;
using System.Drawing;

namespace Scaduino.Components
{
    public partial class Alarms : Component
    {
        private Alarm[] alarms;

        public event EventHandler AlarmStatusChanged;

        /// <summary>
        /// List of alarms
        /// </summary>
        [Description("List of alarms")]
        public Alarm[] AlarmsList
        {
            get => alarms;
            set
            {
                alarms = value;
                if(alarms != null)
                {
                    foreach (var alarm in alarms)
                    {
                        alarm.ClearEvents();
                        alarm.AlarmAck += Alarm_StatusChanged;
                        alarm.AlarmActived += Alarm_StatusChanged;
                        alarm.AlarmInactived += Alarm_StatusChanged;
                    }
                }
            }
        }

        /// <summary>
        /// Text color for inactived alarms
        /// </summary>
        [Description("Text color for actived alarms")]
        public Color ColorInactived { get; set; }

        /// <summary>
        /// Text color for actived alarms
        /// </summary>
        [Description("Text color for actived alarms")]
        public Color ColorActived { get; set; }

        /// <summary>
        /// Text color for acknowledged alarms
        /// </summary>
        [Description("Text color for acknowledged alarms")]
        public Color ColorAck { get; set; }


        private void Alarm_StatusChanged(object sender, EventArgs e)
        {
            AlarmStatusChanged?.Invoke(sender, e);
        }

        public Alarms()
        {
            InitializeComponent();
            ColorInactived = Color.Green;
            ColorActived = Color.Red;
            ColorAck = Color.Yellow;
        }

        public Alarms(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void ClearEvents()
        {
            AlarmStatusChanged = null;
        }
    }
}
