using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public class Hatchback : Car
    {
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
