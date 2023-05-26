using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class InputChecker
    {
        public static string MustMatch(params string[] matches)
        {
            bool isSpecified = false;
            string? userInput;
            do { 
                userInput = Console.ReadLine();
                foreach (string match in matches)
                {
                    if (userInput == null)
                    {
                        break;
                    }
                    else if (userInput.ToLower() == match.ToLower())
                    {
                        isSpecified = true;
                        break;
                    }
                }
                if (!isSpecified)
                {
                    Console.WriteLine("This is not a valid response. Here is a list of valid responses: ");
                    foreach (string option in matches)
                    {
                        Console.WriteLine(option);
                    }
                }
            } while (!isSpecified);

            return userInput;
        }
    }
}
