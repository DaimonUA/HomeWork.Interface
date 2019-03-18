using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Interface
{
    interface ISwitchable
    {
        bool State { get; set; }
        void On();
        void Off();
    }
}
