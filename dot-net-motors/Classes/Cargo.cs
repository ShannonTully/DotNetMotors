using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public class Cargo : Truck
    {
        public override int Wheels { get; set; } = 6;

        public int CargoSpace;

        public override bool Tow()
        {
            return false;
        }

        public override void Setup()
        {
            // Manufacture
        }

        public override void TearDown()
        {
            // Scrap
        }
    }
}
