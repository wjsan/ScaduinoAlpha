using Scaduino.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaduino
{
    static class GlobalData
    {
        static public CommunicationChannels SelectedCommunicationChannels { get; set; }
        static public CommunicationDriver SelectedCommunicationDriver { get; set; }
    }
}
