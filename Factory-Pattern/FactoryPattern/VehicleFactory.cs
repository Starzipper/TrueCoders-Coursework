using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numTires)
        {
            if (numTires < 0)
            {
                numTires = -numTires;
            }
            switch (numTires) {
                case 0:
                    return new Plane();
                case 1:
                    return new Unicycle();
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Trike();
                case 4:
                    return new Car();
                default:
                    return new Train();
            }
        }
    }
}
