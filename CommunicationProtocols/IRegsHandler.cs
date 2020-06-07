using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommunicationProtocols
{
    public interface IRegsHandler
    {
        void SetReg(int address, int value);
        int GetReg(int address);
        void ToggleReg(int address);
    }
}
