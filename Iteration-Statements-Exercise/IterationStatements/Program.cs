namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ThousandCount()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}.");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}.");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void IsEven(int a)
        {
            if ((a % 2) == 0)
            {
                Console.WriteLine($"{a} is even.");
            }
            else
            {
                Console.WriteLine($"{a} is odd.");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void IsPositive(int a)
        {
            if (a < 0)
            {
                Console.WriteLine($"{a} is negative.");
            }
            else if (a > 0)
            {
                Console.WriteLine($"{a} is positive.");
            }
            else
            {
                Console.WriteLine($"{a} is neither positive nor negative.");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            bool parsable;
            int age = 0;
            do
            {
                Console.WriteLine("How old are you?");
                var userInput = Console.ReadLine();
                parsable = int.TryParse(userInput, out age);

                if (!parsable)
                {
                    Console.WriteLine("I need a valid number to continue.");
                }
                else if (age < 0)
                {
                    Console.WriteLine($"Think you're funny, eh? There's no possible way for you to be {age} years old!");
                }

                Console.WriteLine("");

            } while (!parsable || (age < 0));

            if (age >= 18)
            {
                Console.WriteLine("You're allowed to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry, looks like you've got {18 - age} years to go before you can vote!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InTen()
        {
            bool parsable;
            int parsedInput = 0;
            do
            {
                Console.WriteLine("Give me a number.");
                var userInput = Console.ReadLine();
                parsable = int.TryParse(userInput, out parsedInput);

                if(!parsable)
                {
                    Console.WriteLine("You know the drill. I need a real number to work.");
                }

                Console.WriteLine("");
            } while (!parsable);

            if ((parsedInput >= -10) && (parsedInput <= 10))
            {
                Console.WriteLine($"{parsedInput} is in the range of -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{parsedInput} is not in the range of -10 and 10.");
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            bool parsable;
            int parsedInput = 0;
            do
            {
                Console.WriteLine("What number do you want to see the multiplication table of? (From 1 to 12)");
                var userInput = Console.ReadLine();
                parsable = int.TryParse(userInput, out parsedInput);

                if (!parsable || (parsedInput > 12) || (parsedInput < 1))
                {
                    Console.WriteLine("You can only enter a number from 1 to 12.");
                }

                Console.WriteLine("");
            } while (!parsable || (parsedInput > 12) || (parsedInput < 1));

            Console.WriteLine($"Here's the multiplication table for the number {parsedInput}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{parsedInput} * {i} = {parsedInput*i}");
            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            ThousandCount();
            CountByThree();

            // Loop to ensure user input can be parsed
            bool isParsable;
            int parsedNum1 = 0;
            int parsedNum2 = 0;
            do
            {
                // Gets user input
                Console.WriteLine("Give me a number.");
                var userNum1 = Console.ReadLine();

                Console.WriteLine("Give me another number.");
                var userNum2 = Console.ReadLine();

                // Checks if both inputs can be parsed
                isParsable = int.TryParse(userNum1, out parsedNum1);
                if (isParsable)
                {
                    isParsable = int.TryParse(userNum2, out parsedNum2);
                }

                // Tells user that the system will keep asking for numbers until actual numbers are received
                if (!isParsable)
                {
                    Console.WriteLine("I need you to give me numbers so that we can continue.");
                }

                Console.WriteLine("");
            } while (!isParsable); // Continues until inputs are parsable

            IsEqual(parsedNum1, parsedNum2);
            Console.WriteLine("");

            IsEven(parsedNum1);
            IsEven(parsedNum2);
            Console.WriteLine("");

            IsPositive(parsedNum1);
            IsPositive(parsedNum2);
            Console.WriteLine("");

            CanVote();
            Console.WriteLine("");

            InTen();
            Console.WriteLine("");

            MultiplicationTable();
        }
    }
}
