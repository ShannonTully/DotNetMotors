using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Vehicle
    {
        public abstract int Doors { get; set; }
        public abstract int Wheels { get; set; }
        public abstract decimal Price { get; set; }

        public abstract void Setup();
        public abstract void TearDown();
    }
}
