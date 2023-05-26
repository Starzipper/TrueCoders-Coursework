using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rng = new Random();
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
            Console.Write("Hello, welcome to the random activity generator! \n Would you like to generate a random activity? yes/no: ");
            bool cont = InputParser.BoolParse();
            if (cont)
            {
                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                uint userAge = InputParser.UIntParse();
                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? yes/no: ");
                bool seeList = InputParser.BoolParse();
                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        if (activity == activities.Last())
                        {
                            Console.WriteLine(activity);
                        }
                        else
                        {
                            Console.Write($"{activity}, ");
                        }
                        Thread.Sleep(250);
                    }
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList = InputParser.BoolParse();
                Console.WriteLine();
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        if (activity == activities.Last())
                        {
                            Console.WriteLine(activity);
                        }
                        else
                        {
                            Console.Write($"{activity}, ");
                        }
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = InputParser.BoolParse();
                }

                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];
                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}!");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this activity okay? ('yes' to keep; 'no' to redo): ");
                    Console.WriteLine();
                    cont = !InputParser.BoolParse();
                }
            }
            else
            {
                Console.WriteLine("Okay. Have a nice day!");
            }
        }
    }
}