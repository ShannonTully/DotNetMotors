using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Truck : Vehicle
    {
        public override int Doors { get; set; } = 2;
        public override decimal Price { get; set; } = 80000.00m;

        public virtual int Haul(int space)
        {
            return space;
        }

        public virtual bool Tow()
        {
            return true;
        }
    }
}
