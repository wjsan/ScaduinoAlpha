using Scaduino.Components;
using Scaduino.Controls;
using Scaduino.Windows;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Scaduino.ArduinoBoard
{
    public class Pin
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

        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        public Tag Tag { get; set; }
        public int Number { get; set; }
        public PinType Mode { get; set; }
        public string Name { get; set; }

        public Pin()
        {
            Number = 2;
            Mode = PinType.Input;
        }

        public string GetDefineSnippet()
        {
            return $"const int {Name} = {Number};\n";
        }

        public string GetSetupSnippet()
        {
            return $"\tpinMode({Name}, {mode[(int)Mode]});\n";
        }

        public string GetControllerSnippet()
        {
            string output = "";
            switch (Mode)
            {
                case PinType.Input:
                    output += $"\tint {Name}Value = digitalRead({Name});\n";
                    output += $"\tscaduino.setReg({Tag.Name}_TAG, {Name}Value);\n\n";
                    break;
                case PinType.Output:
                    output += $"\tint {Tag.Name} = scaduino.getReg({Tag.Name}_REG);\n";
                    output += $"\tdigitalWrite({Name}, {Tag.Name});\n\n";
                    break;
                case PinType.InputPullUp:
                    output += $"\tint {Name}Value = !digitalRead({Name});\n";
                    output += $"\tscaduino.setReg({Tag.Name}_TAG, {Name}Value);\n\n";
                    break;
                case PinType.AnalogInput:
                    output += $"\tint {Name}Value = !digitalRead({Name});\n";
                    output += $"\tscaduino.setReg({Tag.Name}_TAG, {Name}Value);\n\n";
                    break;
                case PinType.AnalogOutput:
                    output += $"\tint {Tag.Name} = scaduino.getReg({Tag.Name}_REG);\n";
                    output += $"\tanalogWrite({Name}, {Tag.Name});\n\n";
                    break;
                default:
                    break;
            }
            return output;
        }
    }
}
