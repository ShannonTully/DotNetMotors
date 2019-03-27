using System;
using dot_net_motors.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestDoorsPickupGet()
        {
            Pickup pu = new Pickup();

            Assert.Equal(2, pu.Doors);
        }

        [Fact]
        public void TestDoorsCargoGet()
        {
            Cargo cg = new Cargo();

            Assert.Equal(2, cg.Doors);
        }

        [Fact]
        public void TestDoorsHatchGet()
        {
            Hatchback hb = new Hatchback();

            Assert.Equal(4, hb.Doors);
        }

        [Fact]
        public void TestDoorsSoftGet()
        {
            Softtop st = new Softtop();

            Assert.Equal(4, st.Doors);
        }

        [Fact]
        public void TestDoorsHardGet()
        {
            Hardtop ht = new Hardtop();

            Assert.Equal(4, ht.Doors);
        }

        [Fact]
        public void TestWheelsPickupGet()
        {
            Pickup pu = new Pickup();

            Assert.Equal(4, pu.Wheels);
        }

        [Fact]
        public void TestWheelsCargoGet()
        {
            Cargo cg = new Cargo();

            Assert.Equal(6, cg.Wheels);
        }

        [Fact]
        public void TestWheelsHatchGet()
        {
            Hatchback hb = new Hatchback();

            Assert.Equal(4, hb.Wheels);
        }

        [Fact]
        public void TestWheelsSoftGet()
        {
            Softtop st = new Softtop();

            Assert.Equal(4, st.Wheels);
        }

        [Fact]
        public void TestWheelsHardGet()
        {
            Hardtop ht = new Hardtop();

            Assert.Equal(4, ht.Wheels);
        }

        [Fact]
        public void TestPricePickupGet()
        {
            Pickup pu = new Pickup();

            Assert.Equal(80000.00m, pu.Price);
        }

        [Fact]
        public void TestPriceCargoGet()
        {
            Cargo cg = new Cargo();

            Assert.Equal(80000.00m, cg.Price);
        }

        [Fact]
        public void TestPriceHatchGet()
        {
            Hatchback hb = new Hatchback();

            Assert.Equal(40000.00m, hb.Price);
        }

        [Fact]
        public void TestPriceSoftGet()
        {
            Softtop st = new Softtop();

            Assert.Equal(100000.00m, st.Price);
        }

        [Fact]
        public void TestPriceHardGet()
        {
            Hardtop ht = new Hardtop();

            Assert.Equal(100000.00m, ht.Price);
        }

        [Fact]
        public void TestDoorsPickupSet()
        {
            Pickup pu = new Pickup();

            pu.Doors = 4;

            Assert.Equal(4, pu.Doors);
        }

        [Fact]
        public void TestDoorsCargoSet()
        {
            Cargo cg = new Cargo();

            cg.Doors = 4;

            Assert.Equal(4, cg.Doors);
        }
        [Fact]
        public void TestDoorsHatchSet()
        {
            Hatchback hb = new Hatchback();

            hb.Doors = 2;

            Assert.Equal(2, hb.Doors);
        }
        [Fact]
        public void TestDoorsSoftSet()
        {
            Softtop st = new Softtop();

            st.Doors = 2;

            Assert.Equal(2, st.Doors);
        }
        [Fact]
        public void TestDoorsHardSet()
        {
            Hardtop ht = new Hardtop();

            ht.Doors = 2;

            Assert.Equal(2, ht.Doors);
        }
        [Fact]
        public void TestWheelsPickupSet()
        {
            Pickup pu = new Pickup();

            pu.Wheels = 6;

            Assert.Equal(6, pu.Wheels);
        }
        [Fact]
        public void TestWheelsCargoSet()
        {
            Cargo cg = new Cargo();

            cg.Wheels = 4;

            Assert.Equal(4, cg.Wheels);
        }
        [Fact]
        public void TestWheelsHatchSet()
        {
            Hatchback hb = new Hatchback();

            hb.Wheels = 3;

            Assert.Equal(3, hb.Wheels);
        }
        [Fact]
        public void TestWheelsSoftSet()
        {
            Softtop st = new Softtop();

            st.Wheels = 3;

            Assert.Equal(3, st.Wheels);
        }
        [Fact]
        public void TestWheelsHardSet()
        {
            Hardtop ht = new Hardtop();

            ht.Wheels = 3;

            Assert.Equal(3, ht.Wheels);
        }
        [Fact]
        public void TestPricePickupSet()
        {
            Pickup pu = new Pickup();

            pu.Price = 0.0m;

            Assert.Equal(0.0m, pu.Price);
        }
        [Fact]
        public void TestPriceCargoSet()
        {
            Cargo cg = new Cargo();

            cg.Price = 0.0m;

            Assert.Equal(0.0m, cg.Price);
        }
        [Fact]
        public void TestPriceHatchSet()
        {
            Hatchback hb = new Hatchback();

            hb.Price = 0.0m;

            Assert.Equal(0.0m, hb.Price);
        }
        [Fact]
        public void TestPriceSoftSet()
        {
            Softtop st = new Softtop();

            st.Price = 0.0m;

            Assert.Equal(0.0m, st.Price);
        }
        [Fact]
        public void TestPriceHardSet()
        {
            Hardtop ht = new Hardtop();

            ht.Price = 0.0m;

            Assert.Equal(0.0m, ht.Price);
        }

        [Fact]
        public void TestTowPickup()
        {
            Pickup pu = new Pickup();

            Assert.True(pu.Tow());
        }

        [Fact]
        public void TestTowCargo()
        {
            Cargo cg = new Cargo();

            Assert.False(cg.Tow());
        }

        [Fact]
        public void TestHaulPickup()
        {
            Pickup pu = new Pickup();

            Assert.Equal(10, pu.Haul(10));
        }

        [Fact]
        public void TestHaulCargo()
        {
            Cargo cg = new Cargo();

            Assert.Equal(10, cg.Haul(10));
        }

        [Fact]
        public void TestSpaceCargoSet()
        {
            Cargo cg = new Cargo();

            cg.CargoSpace = 10;

            Assert.Equal(10, cg.CargoSpace);
        }

        [Fact]
        public void TestSpaceHatchSet()
        {
            Hatchback hb = new Hatchback();

            hb.CargoSpace = 10;

            Assert.Equal(10, hb.CargoSpace);
        }

        [Fact]
        public void TestScaryFastHatch()
        {
            Hatchback hb = new Hatchback();

            Assert.False(hb.ScaryFast());
        }

        [Fact]
        public void TestScaryFastSoft()
        {
            Softtop st = new Softtop();

            Assert.True(st.ScaryFast());
        }

        [Fact]
        public void TestScaryFastHard()
        {
            Hardtop ht = new Hardtop();

            Assert.True(ht.ScaryFast());
        }

        [Fact]
        public void TestAutoconvertibleSoftSet()
        {
            Softtop st = new Softtop();

            st.AutoConvertible = true;

            Assert.True(st.AutoConvertible);
        }

        [Fact]
        public void TestRollCageHardSet()
        {
            Hardtop ht = new Hardtop();

            ht.RollCage = false;

            Assert.False(ht.RollCage);
        }

        [Fact]
        public void TestCanDrivePickupSet()
        {
            Pickup pu = new Pickup();

            pu.CanDrive = true;

            Assert.True(pu.CanDrive);
        }

        [Fact]
        public void TestCanDriveCargoSet()
        {
            Cargo cg = new Cargo();

            cg.CanDrive = true;

            Assert.True(cg.CanDrive);
        }
        [Fact]
        public void TestCanDriveHatchSet()
        {
            Hatchback hb = new Hatchback();

            hb.CanDrive = true;

            Assert.True(hb.CanDrive);
        }
        [Fact]
        public void TestCanDriveSoftSet()
        {
            Softtop st = new Softtop();

            st.CanDrive = true;

            Assert.True(st.CanDrive);
        }
        [Fact]
        public void TestCanDriveHardSet()
        {
            Hardtop ht = new Hardtop();

            ht.CanDrive = true;

            Assert.True(ht.CanDrive);
        }

        [Fact]
        public void TestFuelTypePickupSet()
        {
            Pickup pu = new Pickup();

            pu.FuelType = "Gas";

            Assert.Equal("Gas", pu.FuelType);
        }

        [Fact]
        public void TestFuelTypeCargoSet()
        {
            Cargo cg = new Cargo();

            cg.FuelType = "Gas";

            Assert.Equal("Gas", cg.FuelType);
        }
        [Fact]
        public void TestFuelTypeHatchSet()
        {
            Hatchback hb = new Hatchback();

            hb.FuelType = "Gas";

            Assert.Equal("Gas", hb.FuelType);
        }
        [Fact]
        public void TestFuelTypeSoftSet()
        {
            Softtop st = new Softtop();

            st.FuelType = "Gas";

            Assert.Equal("Gas", st.FuelType);
        }
        [Fact]
        public void TestFuelTypeHardSet()
        {
            Hardtop ht = new Hardtop();

            ht.FuelType = "Gas";

            Assert.Equal("Gas", ht.FuelType);
        }
    }
}
