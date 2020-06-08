using Scaduino.Components;
using Scaduino.Controls;
using Scaduino.Editors;
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

        /// <summary>
        /// Tag linked to this pin
        /// </summary>
        [Editor(typeof(SelectTagEditor), typeof(UITypeEditor))]
        [Description("Tag linked to this pin")]
        public Tag Tag { get; set; }

        /// <summary>
        /// Name of Tag linked to this pin
        /// </summary>
        [Description("Name of Tag linked to this pin")]
        public string TagName { get => Tag.Name;  }

        /// <summary>
        /// Pin number used in pinMode, digitalWrite and digitalRead methods
        /// </summary>
        [Description("Pin number used in pinMode, digitalWrite and digitalRead methods")]
        public int Number { get; set; }

        /// <summary>
        /// Mode of this pin. Use analog input/output to link this pin with numeric tags.
        /// </summary>
        [Description("Mode of this pin. Use analog input/output to link this pin with numeric tags.")]
        public PinType Mode { get; set; }

        /// <summary>
        /// Name of this pin. Used to give an name to constant number of this pin.
        /// </summary>
        [Description("Name of this pin. Used to give an name to constant number of this pin.")]
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
                    output += $"\tscaduino.setReg({Tag.Name}_REG, {Name}Value);\n\n";
                    break;
                case PinType.Output:
                    output += $"\tint {Tag.Name} = scaduino.getReg({Tag.Name}_REG);\n";
                    output += $"\tdigitalWrite({Name}, {Tag.Name});\n\n";
                    break;
                case PinType.InputPullUp:
                    output += $"\tint {Name}Value = !digitalRead({Name});\n";
                    output += $"\tscaduino.setReg({Tag.Name}_REG, {Name}Value);\n\n";
                    break;
                case PinType.AnalogInput:
                    output += $"\tint {Name}Value = !digitalRead({Name});\n";
                    output += $"\tscaduino.setReg({Tag.Name}_REG, {Name}Value);\n\n";
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
