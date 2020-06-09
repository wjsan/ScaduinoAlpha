using Scaduino.Components;
using Scaduino.Editors;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Threading;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public partial class ScaduinoAlarmsViewer : Panel
    {
        private Alarms alarms;

        private List<Alarm> alarmsList = new List<Alarm>();
        private List<Alarm> alarmsFullHistory = new List<Alarm>();
        private EmailSender emailSettings;

        /// <summary>
        /// Alarms register to be monitored by this viewer
        /// </summary>
        [Category("Scaduino")]
        [Description("Alarms register to be monitored by this viewer")]
        public Alarms Alarms
        {
            get
            {
                return alarms;
            }

            set
            {
                alarms = value;
                alarms.ClearEvents();
                alarms.AlarmStatusChanged += Alarms_AlarmStatusChanged;
            }
        }

        /// <summary>
        /// Enable real-time notifications by e-mails for this alarms
        /// </summary>
        public bool EmailServiceEnabled { get; set; }

        /// <summary>
        /// E-mail settings, to send an real-time alarm notification
        /// </summary>
        [Category("Scaduino")]
        [Description("E-mail settings, to send an real-time alarm notification")]
        [Editor(typeof(EmailSettingsEditor), typeof(UITypeEditor))]
        public EmailSender EmailSettings
        {
            get
            {
                GlobalData.EmailSettings = emailSettings;
                return emailSettings;
            }

            set
            {
                if (value != null)
                    emailSettings = value;
            }
        }

        private void Alarms_AlarmStatusChanged(object sender, System.EventArgs e)
        {
            var alarm = (Alarm)sender;
            if (!alarmsList.Contains(alarm))
            {
                alarmsList.Add(alarm);
            }
            else
            {
                if (alarm.Acknowledged && alarm.Status == Alarm.AlarmState.Inactived)
                {
                    alarmsList.Remove(alarm);
                }
            }
            if (alarm.Status == Alarm.AlarmState.Actived && alarm.Status == Alarm.AlarmState.Acked)
            {
                var alarmHistory = new Alarm()
                {
                    Date = alarm.Date,
                    Message = alarm.Message,
                    Status = alarm.Status,
                    Tag = alarm.Tag,
                    Limit = alarm.Limit,
                    Type = alarm.Type,
                    Acknowledged = alarm.Acknowledged
                };
                alarmsFullHistory.Add(alarmHistory);
            }
            UpdateAlarmsViewer();
        }

        private void UpdateAlarmsViewer()
        {
            if (InvokeRequired)
            {
                return;
            }
            else
            {
                Controls.Clear();
            }
            foreach (var alarm in alarmsList)
            {
                Color foreColor;
                switch (alarm.Status)
                {
                    case Alarm.AlarmState.Inactived:
                        foreColor = Alarms.ColorInactived;
                        break;
                    case Alarm.AlarmState.Actived:
                        foreColor = Alarms.ColorActived;
                        break;
                    case Alarm.AlarmState.Acked:
                        foreColor = Alarms.ColorAck;
                        break;
                    default:
                        foreColor = Alarms.ColorInactived;
                        break;
                }

                var alarmItem = new AlarmItem()
                {
                    StatusImage = imageListAlarmStatus.Images[(int)alarm.Status],
                    MyAlarm = alarm,
                    ForeColor = foreColor,
                    Date = alarm.Date,
                    TagName = alarm.Tag.Name,
                    Message = alarm.Message,
                    Dock = DockStyle.Top,
                    Font = Font
                };

                if (InvokeRequired)
                {
                    return;
                }
                else
                {
                    Controls.Add(alarmItem);
                    if (EmailServiceEnabled && alarm.Status == Alarm.AlarmState.Actived)
                    {
                        ThreadPool.QueueUserWorkItem(
                            (o) => EmailSettings.SendEmail(
                                "ALARM!",
                                $"{alarm.Date}\t" +
                                $"{alarm.TagName}\t" +
                                $"{alarm.Message}")
                        );
                    }
                }

            }
        }

        public ScaduinoAlarmsViewer()
        {
            InitializeComponent();
            BackColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
