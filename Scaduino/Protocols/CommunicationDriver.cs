using CommunicationProtocols;
using Scaduino.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Scaduino.Protocols
{
    public class CommunicationDriver: IRegsHandler, IConnectionHandler
    {

        /// <summary>
        /// Tags collection to be handled by this communiction driver
        /// </summary>
        [Description("Tags collection to be handled by this communiction driver")]
        virtual public Tag[] Tags { get; set; }

        /// <summary>
        /// Name to reference this communication driver
        /// </summary>
        [Description("Name to reference this communication driver")]
        virtual public string Name { get; set; }

        virtual public void Connect()
        {
            throw new NotImplementedException();
        }

        virtual public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public virtual string GetInitCode() { return (""); }
        public virtual string GetInstanceCode() { return (""); }

        virtual public int GetReg(int address)
        {
            throw new NotImplementedException();
        }

        virtual public void SetReg(int address, int value)
        {
            throw new NotImplementedException();
        }

        virtual public void ToggleReg(int address)
        {
            throw new NotImplementedException();
        }
    }
}
