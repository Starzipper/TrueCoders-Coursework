using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving in an abstract fashion.");
        }
    }
}
