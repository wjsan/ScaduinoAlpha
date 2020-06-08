using Scaduino.Components;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Scaduino.Controls
{
    public partial class ScaduinoAlarmsViewer : Panel
    {
        private Alarms alarms;

        private List<Alarm> AlarmsList = new List<Alarm>();
        private List<Alarm> AlarmsFullHistory = new List<Alarm>();

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
        public bool EnableEmailService { get; set; }

        /// <summary>
        /// E-mail settings, to send an real-time alarm notification
        /// </summary>
        [Category("Scaduino")]
        [Description("E-mail settings, to send an real-time alarm notification")]
        public EmailSender EmailSettings { get; set; }

        private void Alarms_AlarmStatusChanged(object sender, System.EventArgs e)
        {
            var alarm = (Alarm)sender;
            if (!AlarmsList.Contains(alarm)){
                AlarmsList.Add(alarm);
            }
            else
            {
                if(alarm.Acknowledged && alarm.Status == Alarm.AlarmState.Inactived)
                {
                    AlarmsList.Remove(alarm);
                }
            }
            if(alarm.Status == Alarm.AlarmState.Actived && alarm.Status == Alarm.AlarmState.Acked)
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
                AlarmsFullHistory.Add(alarmHistory);
            }
            UpdateAlarmsViewer();
        }

        private void UpdateAlarmsViewer()
        {
            Controls.Clear();
            foreach (var alarm in AlarmsList)
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
                Controls.Add(alarmItem);

                if (EnableEmailService)
                {
                    ThreadPool.QueueUserWorkItem(
                        (o) => EmailSettings.SendEmail("Alarm!", alarm.Message)
                    );
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
