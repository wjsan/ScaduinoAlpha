using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Scaduino.Components
{
    public class Tag
    {
        private string name;
        private int _value;
        private int address;

        public event EventHandler TagValueChanged;

        /// <summary>
        /// Name of tag
        /// </summary>
        [Description("Name of tag")]
        public string Name { get => name; set => name = RemoveSpecialCharacters(value); }

        /// <summary>
        /// Value of tag
        /// </summary>
        [Description("Value of tag")]
        [Browsable(false)]
        public int Value 
        { 
            get => _value; 
            set
            {
                _value = value;
                if(TagValueChanged != null)
                    TagValueChanged(this, new EventArgs());
            }  
        }

        private string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public void setAddress(int address)
        {
            this.address = address;
        }

        public int getAddress() => address;
    }
}
