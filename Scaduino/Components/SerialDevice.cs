using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scaduino.Components
{
    public partial class SerialDevice : Device
    {
        private SerialPort serialPort = new SerialPort();

        [Category("Serial")]
        [Description("Serial port of this component.")]
        public string PortName { 
            get => serialPort.PortName;
            set
            {
                serialPort.PortName = value;
            }
        }

        [Category("Serial")]
        [Description("Baud rate of this component.")]
        public int BaudRate { get => serialPort.BaudRate; set => serialPort.BaudRate = value; }

        [Category("Scaduino")]
        [Description("Get components code")]
        public string ComponentsCode
        {
            get
            {
                string code = "#include \"BqBus.h\"\n\n";
                code += "BqBus scaduino(" + Controls.Count + ");\t //Create scaduino instance\n\n";
                code += "void setup(){\n";
                code += "\tSerial.begin(" + BaudRate +");\t//Initialize Serial Port of your device\n";
                code += "\tscaduino.setBus(&Serial);\t //Set winch Serial Port of your device will be use to communicato with Scaduino\n";
                code += "\t\n\t/*your setup code goes here*/\n\n";
                code += "}\n\n";
                code += "void loop(){\n";
                code += "\tscaduino.communicationTask();\t //Perform communication between your device and Scaduino interface\n\n";
                int i = 0;
                foreach (Control control in Controls)
                {
                    code += "\tint " + control.Name + " = scaduino.getReg(" + i + ");\t //Read '" + control.Name + "' Scaduino " + control.GetType().Name + "\n";
                    i++;
                }
                code += "\t\n\t/*your code goes here*/\n\n}";
                return code;
            }
        }

        public SerialDevice()
        {
            InitializeComponent();
            BqBus.Serial = serialPort;
        }

        public SerialDevice(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            BqBus.Serial = serialPort;
        }

    }
}
