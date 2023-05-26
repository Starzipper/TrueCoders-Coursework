using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public double Wingspan { get; set; }
        public void Chirp ()
        {
            Console.WriteLine("Chirp!");
        }
        public void Fly ()
        {
            Console.WriteLine("The bird is flying.");
        }
        public void BuildNest()
        {
            Console.WriteLine("The bird built a nest.");
        }
    }
}
