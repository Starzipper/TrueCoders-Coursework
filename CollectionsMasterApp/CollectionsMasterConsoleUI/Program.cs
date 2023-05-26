﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"{ numArray[0]} is the first number of the array.");

            //TODO: Print the last number of the array
            Console.WriteLine($"{numArray[numArray.Length - 1]} is the last number of the array.");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            // Way 1
            Array.Reverse(numArray);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numArray);
            Array.Reverse(numArray);

            // Way 2
            ReverseArray(numArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            NumberPrinter(numArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(numArray);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Initial list capacity is {numList.Capacity}.");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList, 50);

            //TODO: Print the new capacity
            Console.WriteLine($"List capacity is now {numList.Capacity} after population.");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool isParsable = false;
            int parsedInput = 0;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                var userInput = Console.ReadLine();
                isParsable = int.TryParse(userInput, out parsedInput);

                if (!isParsable)
                {
                    Console.WriteLine("That is not a valid number.");
                }

            } while (!isParsable);
            Console.WriteLine("");
            NumberChecker(numList, parsedInput);

            Console.WriteLine("Press any key to continue to the whole list...");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var listToArray = new int[numList.Count];
            for (int i = 0; i < numList.Count; i++)
            {
                listToArray[i] = numList.ElementAt(i);
            }

            //TODO: Clear the list
            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                do
                {
                    if (numberList.ElementAt(i) % 2 != 0)
                    {
                        numberList.Remove(numberList.ElementAt(i));
                    }
                    if (numberList.Count <= i)
                    {
                        break;
                    }
                } while (numberList.ElementAt(i) % 2 != 0);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool inList = false;
            foreach (int number in numberList)
            {
                if (number == searchNumber)
                {
                    Console.WriteLine($"{searchNumber} is in the list.");
                    inList = true;
                    break;
                }
            }
            if (!inList)
            {
                Console.WriteLine($"{searchNumber} is not in the list.");
            }
        }

        private static void Populater(List<int> numberList, int numElements)
        {
            Random rng = new Random();
            for (int i = 0; i < numElements; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            var earlyElement = 0;
            var laterElement = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                earlyElement = array[i];
                laterElement = array[array.Length - 1 - i];

                array[i] = laterElement;
                array[array.Length - 1 - i] = earlyElement;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
