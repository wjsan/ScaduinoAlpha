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
        string Name { get; set; }
        
        Tag Tag { get; set; }

        ICommunicationDriver CommunicationLink { get; set; }
    }
}
