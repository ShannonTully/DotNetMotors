using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public class Hardtop : Convertible, ISpeed, IMileage
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

        public bool RollCage;

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
