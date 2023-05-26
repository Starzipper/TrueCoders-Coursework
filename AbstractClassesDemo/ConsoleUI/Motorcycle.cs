using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving in an abstract fashion.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle is driving virtually.");
        }
    }
}
