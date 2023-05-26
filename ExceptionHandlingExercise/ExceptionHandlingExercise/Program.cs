using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            char[] arr = { '3', 'g', '7', 'a', '1', 'e', '9', '8', '4'};
            var numbers = new List<int>();
            string str = String.Empty;


            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            foreach (char chars in arr)
            {
                // Now create a try catch
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list
                    str = chars.ToString();
                    int strToInt = int.Parse(str);
                    numbers.Add(strToInt);
                }
                catch 
                {
                    // catch your Exception:
                    // in the scope of your catch you can use the following, 
                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                    Console.WriteLine($"Unable to Parse '{chars}'");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Numbers parsed: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
