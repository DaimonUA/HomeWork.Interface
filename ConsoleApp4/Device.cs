using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Interface
{
    abstract public class Device:ISwitchable
    {
        private int? number;
        private int anyproperties;
        public int? AnyProperties
        {
            get
            {
                return anyproperties;

            }
            set
            {
                anyproperties = value.HasValue?value.Value:0;//value.Value;
            }
        }
        public int Number { get; set; }
        public abstract string Type { get; }
        public abstract bool State { get; set; }
        public abstract void Off();
        public abstract void On();
        public sealed override string ToString()
        {
            string res = Type + " " + Number.ToString() + " " + (State ? "вкл.": "выкл");

            return res;
        }
    }
}
