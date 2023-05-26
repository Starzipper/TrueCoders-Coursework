using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Year { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public double TopSpeed { get; set; }
    }
}
