using BqBusNet;
using Scaduino.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using CommunicationProtocols;

namespace Scaduino.Protocols
{
    [ToolboxItem(false)]
    public partial class BqBusSerialDriver : CommunicationDriver
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        private Tag[] tags;

        private BqBusSerial bqBusSerial;

        /// <summary>
        /// Name to reference this communication driver
        /// </summary>
        [Description("Name to reference this communication driver")]
        override public string Name { get; set; }

        /// <summary>
        /// Auto connect to device at application startup
        /// </summary>
        [Description("Auto connect to device at application startup")]
        override public bool AutoConnect { get; set; }

        /// <summary>
        /// Tags collection to be handled by this communiction driver
        /// </summary>
        [Description("Tags collection to be handled by this communiction driver")]
        override public Tag[] Tags
        {
            get => tags;
            set
            { 
                tags = value;
                if (tags == null) return;
                bqBusSerial.Size = tags.Length;
                int i = 0;
                List<string> tagNames = new List<string>();
                foreach (var tag in tags)
                {
                    if (!tagNames.Contains(tag.Name))
                    {
                        tagNames.Add(tag.Name);
                        tag.TagValueChanged += Tag_TagValueChanged;
                        tag.setAddress(i);
                        i++;
                    }
                }
            }
        }

        private void Tag_TagValueChanged(object sender, EventArgs e)
        {
            var tag = (Tag)sender;
            bqBusSerial.SetReg(tag.getAddress(), tag.Value);
        }

        public string PortName 
        { 
            get => bqBusSerial.Serial.PortName;
            set => bqBusSerial.Serial.PortName = value;
        }

        public int BaudRate
        {
            get => bqBusSerial.Serial.BaudRate;
            set => bqBusSerial.Serial.BaudRate = value;
        }

        public BqBusSerialDriver()
        {
            Initialize();
            InitializeComponent();
        }

        private void Initialize()
        {
            Name = "BqBusSerial";
            bqBusSerial = new BqBusSerial();
            bqBusSerial.Serial = new System.IO.Ports.SerialPort();
            bqBusSerial.DataRecieved += BqBusSerial_DataRecieved;
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 500;
            if (!GlobalData.IsInDesignMode)
            {
                timer.Start();
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Connect();
            timer.Stop();
        }

        private void BqBusSerial_DataRecieved(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var tag in Tags)
            {
                tag.Value  = bqBusSerial.GetReg(i);
                i++;
            }
        }

        override public string GetInstanceCode()
        {
            string code = "BqBus scaduino(" + bqBusSerial.Size + ");\n";
            return code;
        }

        override public string GetInitCode()
        {
            string code = "\tSerial.begin(" + BaudRate + ");\n";
            code += "\tscaduino.setBus(&Serial);\n";
            return code;
        }

        override public void SetReg(int address, int value)
        {
            bqBusSerial.SetReg(address, value);
        }

        override public int GetReg(int address)
        {
            return bqBusSerial.GetReg(address);
        }

        override public void ToggleReg(int address)
        {
            bqBusSerial.ToggleReg(address);
        }

        override public void Connect()
        {
            bqBusSerial.Connect();
        }

        override public void Disconnect()
        {
            bqBusSerial.Disconnect();
        }
    }
}
