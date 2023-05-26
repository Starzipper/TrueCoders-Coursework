using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car()
            {
                Year = 2020,
                Make = "Kia",
                Model = "Soul",
                Color = "Red",
                YearFounded = 1944,
                TopSpeed = 128,
                GasMileage = 30
            };
            var truck = new Truck()
            {
                Year = 2021,
                Make = "Ford",
                Model = "F150",
                Color = "Silver",
                YearFounded = 1903,
                TopSpeed = 107,
                BedSize = 80,
                TowingCapacity = 8200
            };
            var suv = new SUV()
            {
                Year = 2023,
                Make = "Toyota",
                Model = "RAV4",
                Color = "Black",
                YearFounded = 1937,
                TopSpeed = 114,
                HoldSize = 37.6,
                SeatingCapacity = 5
            };
            Console.WriteLine("Hello, thank you for visiting this very real car store where we sell very real cars. \n Allow me to show you what we have in stock!");
            Console.WriteLine("");
            Console.WriteLine($"Here we have this {car.Color} {car.Year} {car.Make} {car.Model} from the company {car.Make} which was founded in {car.YearFounded}." +
                $"\n Its top speed is {car.TopSpeed} miles per hour and it has a gas mileage of {car.GasMileage} miles per gallon.");
            Console.WriteLine("");
            Console.WriteLine($"And here we have this {truck.Color} {truck.Year} {truck.Make} {truck.Model} which can tow up to {truck.TowingCapacity} pounds!" +
                $"\n Ignore the fact that it's a {truck.Make}, this is a good quality vehicle, I swear! Its bed is {truck.BedSize} inches large and it's a great choice " +
                $"for the handy man!");
            Console.WriteLine("");
            Console.WriteLine($"Last, but not least, we have this {suv.Color} {suv.Year} {suv.Make} {suv.Model}! This is a great choice for families! " +
                $"\n It can hold {suv.SeatingCapacity} passengers and still has ample space even when full! Its cargo hold is {suv.HoldSize} sqaure inches " +
                $"so you can also squeeze some kids back there if {suv.SeatingCapacity} seats aren't enough, haha!");
        }
    }
}
