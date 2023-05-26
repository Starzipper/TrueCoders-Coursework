using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsShedding { get; set; }
        public double Length { get; set; }
        public void Bask ()
        {
            Console.WriteLine("The reptile is basking in the sun.");
        }
        public void Hunt ()
        {
            Console.WriteLine("The reptile is hunting for food.");
        }
    }
}
