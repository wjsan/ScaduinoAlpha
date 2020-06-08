using Scaduino.Components;
using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaduino.Controls
{
    public interface IScaduinoControl
    {
        CommunicationChannels CommunicationSource { get; set; }

        Tag Tag { get; set; }

        string TagName { get; }
    }
}
