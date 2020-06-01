using CommunicationProtocols;
using Scaduino.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaduino.Protocols
{
    public interface ICommunicationDriver: IRegsHandler, IConnectionHandler
    {
        Tag[] Tags { get; set; }
        string GetInitCode();
        string GetInstanceCode();
    }
}
