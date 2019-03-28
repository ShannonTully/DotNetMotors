using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public class Pickup : Truck, ISpeed, IMileage
    {
        public bool CanDrive { get; set; }
        public string FuelType { get; set; }

        public int Mph()
        {
            return 20;
        }

        public int Mpg()
        {
            return 20;
        }

        public override int Wheels { get; set; } = 4;

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
