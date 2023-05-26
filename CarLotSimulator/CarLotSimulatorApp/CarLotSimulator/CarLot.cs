using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarList { get; set; }
        public static int NumberOfCars = 0;

        public CarLot()
        {
            CarList = new List<Car>();
        }
    }
}
