using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Car : Vehicle
    {
        public override int Doors { get; set; } = 4;
        public override int Wheels { get; set; } = 4;

        public virtual bool ScaryFast()
        {
            return true;
        }
    }
}
