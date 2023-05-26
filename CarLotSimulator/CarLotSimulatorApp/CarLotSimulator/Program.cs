using System;
using System.Linq;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car                                                                   Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable           Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()                                  Done
            //The methods should take one string parameter: the respective noise property                               Done


            //Now that the Car class is created we can instanciate 3 new cars                                           Done
            //Set the properties for each of the cars                                                                   Done
            //Call each of the methods for each car                                                                     Done
            var carLot = new CarLot();
            Console.WriteLine($"There are {CarLot.NumberOfCars} cars in the car lot.");

            var myCar = new Car();
            myCar.Year = 2020;
            myCar.Make = "Kia";
            myCar.Model = "Soul";
            myCar.EngineNoise = "low";
            myCar.HonkNoise = "normal";
            myCar.isDriveable = false;
            carLot.CarList.Add(myCar);
            Console.WriteLine($"There is {CarLot.NumberOfCars} car in the car lot.");

            var partnerCar = new Car() { Year = 2017, Make = "Hyundai", Model = "Sonata", EngineNoise = "normal", HonkNoise = "low", isDriveable = true };
            carLot.CarList.Add(partnerCar);
            Console.WriteLine($"There are {CarLot.NumberOfCars} cars in the car lot.");

            var oldCar = new Car()
            {
                Year = 2012,
                Make = "Hyundai",
                Model = "Elantra",
                EngineNoise = "high",
                HonkNoise = "high",
                isDriveable = false
            };
            carLot.CarList.Add(oldCar);
            Console.WriteLine($"There are {CarLot.NumberOfCars} cars in the car lot.");

            Console.WriteLine("These are the sounds my car makes.");
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);

            Console.WriteLine("These are the sounds my partner's car makes.");
            partnerCar.MakeEngineNoise(partnerCar.EngineNoise);
            partnerCar.MakeHonkNoise(partnerCar.HonkNoise);

            Console.WriteLine("These are the sounds my old car makes.");
            oldCar.MakeEngineNoise(oldCar.EngineNoise);
            oldCar.MakeHonkNoise(oldCar.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car                 Done

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars                                                      Done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. Done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console           Done

            for (int i = 0; i < carLot.CarList.Count; i++)
            {
                Console.WriteLine($"This car is a {carLot.CarList.ElementAt(i).Year} {carLot.CarList.ElementAt(i).Make} {carLot.CarList.ElementAt(i).Model}.");
            }
        }
    }
}
