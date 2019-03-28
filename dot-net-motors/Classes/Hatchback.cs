using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public class Hatchback : Car, ISpeed, IMileage
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

        public int CargoSpace;

        public override decimal Price { get; set; } = 40000.00m;

        public override bool ScaryFast()
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
