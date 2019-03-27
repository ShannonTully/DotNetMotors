using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    interface ISpeed
    {
        bool CanDrive { get; set; }

        int Mph();
    }
}
