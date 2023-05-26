using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car : CarLot
    {
        public Car()
        {
            NumberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDriveable { get; set; }

        public void MakeEngineNoise (string noiseProperty)
        {
            if (noiseProperty == "low")
            {
                Console.WriteLine("vroom.");
            }
            else if (noiseProperty == "high")
            {
                Console.WriteLine("VROOM!");
            }
            else
            {
                Console.WriteLine("Vroom!");
            }
        }

        public void MakeHonkNoise (string noiseProperty)
        {
            if (noiseProperty == "low")
            {
                Console.WriteLine("honk.");
            }
            else if (noiseProperty == "high")
            {
                Console.WriteLine("HONK!");
            }
            else
            {
                Console.WriteLine("Honk!");
            }
        }
    }
}
