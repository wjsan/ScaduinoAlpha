﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace Scaduino.Components
{
    public partial class SerialArduino : SerialDevice
    {
        private List<Pin> pins;

        public void AddPin(Pin pin)
        {
            pins.Add(pin);
        }

        public void RemovePin(Pin pin)
        { 
            pins.Remove(pin);
            pin.Dispose();
        }

        [Category("Scaduino")]
        [Description("Get components code")]
        new public string ComponentsCode
        {
            get
            {
                string code = "#include \"BqBus.h\"\n\n";
                code += $"BqBus scaduino({Controls.Count});\t //Create scaduino instance\n\n";
                int i = 0;
                code += "enum ScaduinoRegs{\n";
                foreach (Control control in Controls)
                {
                    code += $"\t{control.Name}Reg,\n";
                    i++;
                }
                code += "};\n\n";
                foreach (Pin pin in pins)
                {
                    code += pin.GetDefine(nameof(pin));
                    i++;
                }
                code += "\n";
                code += "void setup(){\n";
                code += "\t/*scaduino setup*/\n";
                code += $"\tSerial.begin({BaudRate});\t//Initialize Serial Port of your device\n";
                code += "\tscaduino.setBus(&Serial);\t //Set wich Serial Port of your device will be use to communicato with Scaduino\n";
                foreach (Pin pin in pins)
                {
                    code += pin.GetSetup(nameof(pin));
                }
                code += "}\n\n";
                code += "void loop(){\n";
                code += "\tscaduino.communicationTask();\t //Perform communication between your device and Scaduino interface\n\n";
                i = 0;
                foreach (Pin pin in pins)
                {
                    code += pin.GetControlSnippet(nameof(pin), Controls[i].Name);
                    i++;
                }
                code += "}";
                return code;
            }
        }

        public SerialArduino()
        {
            InitializeComponent();
            pins = new List<Pin>();
        }

        public SerialArduino(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            pins = new List<Pin>();
        }
    }
}
