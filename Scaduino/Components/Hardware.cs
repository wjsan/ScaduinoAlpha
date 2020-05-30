using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Scaduino.Components
{
    class Hardware: IList
    {

    }

    public partial class NewPin
    {
        public IList<string> names { get; set; }

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

        public SerialArduino Arduino
        {
            get => device;
            set
            {
                //device?.RemovePin(this);
                device = value;
               // device?.AddPin(this);
            }
        }

        public int PinNumber { get; set; }
        public PinType PinMode { get; set; }

        public NewPin()
        {
            PinNumber = 2;
            PinMode = PinType.Input;
            List<string> teste = new List<string>();
            teste.Add("teste");
            names = teste;
        }

        public string GetDefine(string pinName)
        {
            return $"const int {pinName} = {PinNumber};\n";
        }

        public string GetSetup(string pinName)
        {
            return $"\tpinMode({pinName}, {mode[(int)PinMode]});\n";
        }

        public string GetControlSnippet(string pinName, string controlName)
        {
            string output = "";
            switch (PinMode)
            {
                case PinType.Input:
                    output += $"\tint {pinName}Value = digitalRead({pinName});\n";
                    output += $"\tscaduino.setReg({controlName}Reg, {pinName}Value);\n\n";
                    break;
                case PinType.Output:
                    output += $"\tint {controlName} = scaduino.getReg({controlName}Reg);\n";
                    output += $"\tdigitalWrite({pinName}, {controlName});\n\n";
                    break;
                case PinType.InputPullUp:
                    output += $"\tint {pinName}Value = !digitalRead({pinName});\n";
                    output += $"\tscaduino.setReg({controlName}Reg, {pinName}Value);\n\n";
                    break;
                case PinType.AnalogInput:
                    output += $"\tint {pinName}Value = !digitalRead({pinName});\n";
                    output += $"\tscaduino.setReg({controlName}Reg, {pinName}Value);\n\n";
                    break;
                case PinType.AnalogOutput:
                    output += $"\tint {controlName} = scaduino.getReg({controlName}Reg);\n";
                    output += $"\tanalogWrite({pinName}, {controlName});\n\n";
                    break;
                default:
                    break;
            }
            return output;
        }
    }
}
