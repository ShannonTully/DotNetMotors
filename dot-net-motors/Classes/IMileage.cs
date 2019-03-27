using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    interface IMileage
    {
        string FuelType { get; set; }

        int Mpg();
    }
}
