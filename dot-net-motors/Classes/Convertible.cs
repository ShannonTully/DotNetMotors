using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Convertible : Car
    {
        public override decimal Price { get; set; } = 100000.00m;
    }
}
