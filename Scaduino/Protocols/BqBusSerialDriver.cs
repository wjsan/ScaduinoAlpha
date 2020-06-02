using BqBusNet;
using Scaduino.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using CommunicationProtocols;

namespace Scaduino.Protocols
{
    public partial class BqBusSerialDriver : Component, Scaduino.Protocols.ICommunicationDriver
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        private Tag[] tags;

        private BqBusSerial bqBusSerial;

        public bool AutoConnect { get; set; }

        public Tag[] Tags
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

        public BqBusSerialDriver(IContainer container)
        {
            container.Add(this);
            Initialize();
            InitializeComponent();
        }

        private void Initialize()
        {
            bqBusSerial = new BqBusSerial();
            bqBusSerial.Serial = new System.IO.Ports.SerialPort();
            bqBusSerial.DataRecieved += BqBusSerial_DataRecieved;
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 500;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (AutoConnect)
                Connect();
            timer.Stop();
        }

        private void BqBusSerial_DataRecieved(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var tag in Tags)
            {
                tag.Value = bqBusSerial.GetReg(i);
                i++;
            }
        }

        public string GetInstanceCode()
        {
            string code = "BqBus scaduino(" + bqBusSerial.Size + ");\n";
            return code;
        }

        public string GetInitCode()
        {
            string code = "\tSerial.begin(" + BaudRate + ");\n";
            code += "\tscaduino.setBus(&Serial);\n";
            return code;
        }

        public void SetReg(int address, int value)
        {
            bqBusSerial.SetReg(address, value);
        }

        public int GetReg(int address)
        {
            return bqBusSerial.GetReg(address);
        }

        public void ToggleReg(int address)
        {
            bqBusSerial.ToggleReg(address);
        }

        public void Connect()
        {
            bqBusSerial.Connect();
        }

        public void Disconnect()
        {
            bqBusSerial.Disconnect();
        }
    }
}
