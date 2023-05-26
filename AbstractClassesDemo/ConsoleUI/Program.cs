using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var myCar = new Car()
            {
                Year = "2020",
                Make = "Kia",
                Model = "Soul"
            };
            var motorcycle = new Motorcycle()
            {
                Year = "2021",
                Make = "Harley Davidson",
                Model = "Road Glide"
            };
            Vehicle oldCar = new Car()
            {
                Year = "2008",
                Make = "Hyudai",
                Model = "Elantra"
            };
            Vehicle otherMotorcycle = new Motorcycle()
            {
                Year = "2018",
                Make = "Harley Davidson",
                Model = "Low Rider S"
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(myCar);
            vehicles.Add(motorcycle);
            vehicles.Add(oldCar);
            vehicles.Add(otherMotorcycle);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This vehicle is a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            }
            Console.WriteLine("");
            // Call each of the drive methods for one car and one motorcycle
            myCar.DriveVirtual();
            myCar.DriveAbstract();
            motorcycle.DriveVirtual();
            motorcycle.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
