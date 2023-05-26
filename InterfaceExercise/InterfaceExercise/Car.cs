using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double TopSpeed { get; set; }
        public int YearFounded { get; set; }
        public string Color { get; set; }
        public bool HasTrunk { get; set; } = true;
        public double GasMileage { get; set; }
    }
}
