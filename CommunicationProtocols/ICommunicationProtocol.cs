using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommunicationProtocols
{
    public interface ICommunicationProtocol
    {
        event EventHandler DataRecieved;
    }
}
