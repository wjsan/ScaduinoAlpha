using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Scaduino.Components
{
    public partial class Pin : Component
    {

        public enum PinType
        {
            Input,
            Output,
            InputPullUp,
            AnalogInput,
            AnalogOutput
        }

        private string[] mode =
        {
            "INPUT",
            "OUTPUT",
            "INPUT_PULLUP",
            "INPUT",
            "OUTPUT"
        };
        private SerialArduino device;

        public SerialArduino Arduino { 
            get => device;
            set
            {
                device?.RemovePin(this);
                device = value;
                device?.AddPin(this);
            }
        }
        public string PinName { get; set; }
        public int PinNumber { get; set; }
        public PinType PinMode { get; set; }

        public Pin()
        {
            PinName = "Pin";
            PinNumber = 2;
            PinMode = PinType.Input;
        }

        public string GetDefine()
        {
            return $"const int {PinName} = {PinNumber};\n";
        }

        public string GetSetup()
        {
            return $"\tpinMode({PinName}, {mode[(int)PinMode]});\n";
        }

        public string GetControlSnippet(string controlName)
        {
            string output = "";
            switch (PinMode)
            {
                case PinType.Input:
                    output += $"\tint {PinName}Value = digitalRead({PinName});\n";
                    output += $"\tscaduino.setReg({controlName}Reg, {PinName}Value);\n\n";
                    break;
                case PinType.Output:
                    output += $"\tint {controlName} = scaduino.getReg({controlName}Reg);\n";
                    output += $"\tdigitalWrite({PinName}, {controlName});\n\n";
                    break;
                case PinType.InputPullUp:
                    output += $"\tint {PinName}Value = !digitalRead({PinName});\n";
                    output += $"\tscaduino.setReg({controlName}Reg, {PinName}Value);\n\n";
                    break;
                case PinType.AnalogInput:
                    output += $"\tint {PinName}Value = !digitalRead({PinName});\n";
                    output += $"\tscaduino.setReg({controlName}Reg, {PinName}Value);\n\n";
                    break;
                case PinType.AnalogOutput:
                    output += $"\tint {controlName} = scaduino.getReg({controlName}Reg);\n";
                    output += $"\tanalogWrite({PinName}, {controlName});\n\n";
                    break;
                default:
                    break;
            }
            return output;
        }
    }
}
