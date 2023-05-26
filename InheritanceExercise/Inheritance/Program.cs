using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes  Done

            // Create a class Animal                                            Done
            // give this class 4 members that all Animals have in common        Done


            // Create a class Bird                                              Done
            // give this class 4 members that are specific to Bird              Done
            // Set this class to inherit from your Animal Class                 Done

            // Create a class Reptile                                           Done
            // give this class 4 members that are specific to Reptile           Done
            // Set this class to inherit from your Animal Class                 Done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird()
            {
                IsSleepy = true,
                IsHungry = false,
                Weight = 1.5,
                NumLegs = 2,
                Wingspan = 3
            };
            Console.WriteLine($"My bird weighs {myBird.Weight} pounds and has a wingspan of {myBird.Wingspan} feet. \n It has {myBird.NumLegs} legs like any other bird.");
            myBird.Chirp();
            myBird.Fly();
            if (myBird.IsSleepy)
            {
                Console.WriteLine("The bird is sleepy.");
            }
            else
            {
                Console.WriteLine("The bird is not sleepy.");
            }

            if (myBird.IsHungry)
            {
                Console.WriteLine("The bird is hungry.");
            }
            else
            {
                Console.WriteLine("The bird is not hungry.");
            }
            myBird.BuildNest();
            Console.WriteLine("The bird has decided to sleep in its nest. Goodnight, bird!");
            Console.WriteLine("");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var wildReptile = new Reptile()
            {
                IsSleepy = false,
                IsHungry = true,
                Weight = 170,
                NumLegs = 4,
                IsShedding = false,
                Length = 8
            };
            wildReptile.Bask();
            Console.WriteLine($"This wild reptile is {wildReptile.Length} feet long and {wildReptile.Weight} pounds. \n It has {wildReptile.NumLegs} legs.");
            Console.WriteLine($"This reptile {(wildReptile.IsShedding == true ? "is" : "is not")} shedding.");
            if (wildReptile.IsSleepy)
            {
                Console.WriteLine("The reptile is sleepy.");
            }
            else
            {
                Console.WriteLine("The reptile is not sleepy.");
            }

            if (wildReptile.IsHungry)
            {
                Console.WriteLine("The reptile is hungry.");
            }
            else
            {
                Console.WriteLine("The reptile is not hungry.");
            }
            wildReptile.Hunt();
        }
    }
}
