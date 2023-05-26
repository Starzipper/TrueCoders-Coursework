using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public static class InputParser
    {
        public static bool BoolParse()
        {
            bool isValid = false;
            bool yes = false;
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (userInput == null)
                {
                    // Do nothing
                }
                else if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    yes = true;
                    isValid = true;
                }
                else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    isValid = true;
                }

                if (!isValid)
                {
                    Console.WriteLine("That input is not valid. Please respond with 'yes' or 'no'.");
                }
            } while (!isValid);
            return yes;
        }

        public static uint UIntParse()
        {
            bool isValid = false;
            uint desiredParse;
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                isValid = uint.TryParse(userInput, out desiredParse);

                if (!isValid)
                {
                    Console.WriteLine("That value is not valid. Please enter a positive integer.");
                }
            } while (!isValid);
            return desiredParse;
        }
    }
}
