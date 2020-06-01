using Scaduino.Components;
using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Scaduino.ArduinoBoard;

namespace Scaduino.ArduinoBoard
{
    public partial class Arduino : Component
    {
        private ICommunicationDriver communicationLink;

        public ICommunicationDriver CommunicationLink
        {
            get => communicationLink;
            set
            {
                communicationLink = value;
                if (communicationLink != null)
                    Editors.SelectTag.Tags = communicationLink.Tags;
            }
        }

        public Pin[] Pins { get; set; }

        public CodeManager CodeManager { get; }

        public string GetCode()
        {
            string code = "";
            code += "#include \"BqBus.h\"\n\n";
            code += CommunicationLink.GetInstanceCode();
            code += "\nenum Tags {\n";
            foreach (Tag tag in CommunicationLink.Tags)
            {
                code += "\t" + tag.Name + "_REG,\n";
            }
            code += "};\n\n";
            foreach (Pin pin in Pins)
            {
                code += pin.GetDefineSnippet();
            }
            code += "\nvoid setup(){\n";
            code += communicationLink.GetInitCode();
            foreach (Pin pin in Pins)
            {
                code += pin.GetSetupSnippet();
            }
            code += "}\n\n";
            code += "void loop(){\n";
            code += "\tscaduino.communicationTask();\n\n";
            foreach (Pin pin in Pins)
            {
                code += pin.GetControllerSnippet();
            }
            code += "}\n";
            return (code);
        }

        public Arduino()
        {
            InitializeComponent();
            CodeManager = new CodeManager(this);
        }

        public Arduino(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            CodeManager = new CodeManager(this);
        }
    }
}
