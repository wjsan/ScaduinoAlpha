using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommunicationProtocols
{
    public interface IConnectionHandler
    {
        void Connect();
        void Disconnect();
    }
}
