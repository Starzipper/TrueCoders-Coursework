using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class InputChecker
    {
        public static int ParseToInt()
        {
            bool isParsable = false;
            int parsedValue;
            do
            {
                string? userInput = Console.ReadLine();
                isParsable = int.TryParse(userInput, out parsedValue);

                if (!isParsable)
                {
                    Console.WriteLine("That is not a valid integer. Please enter an integer number.");
                }
            } while (!isParsable);

            return parsedValue;
        }
    }
}
