namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("Hello, welcome to our banking application! \n \n How much money would you like to deposit in your bank account today?");
            bool isParsable = false;
            double parsedInput;
            do
            {
                var userInput = Console.ReadLine();
                isParsable = double.TryParse(userInput, out parsedInput);
                
                if (!isParsable)
                {
                    Console.WriteLine("I'm sorry, that is not a valid number. Please try again.");
                }

            } while (!isParsable);

            myAccount.Deposit(parsedInput);
            Console.WriteLine("Deposit complete.");

            bool isValid = false;
            do
            {
                Console.WriteLine("Would you like to see your current balance? (y or n)");
                var balanceInput = Console.ReadLine();

                if (balanceInput == null)
                {
                    Console.WriteLine("I need a yes or no.");
                }
                else if (balanceInput.ToLower() == "y" || balanceInput.ToLower() == "yes")
                {
                    Console.WriteLine($"Your current balance is ${myAccount.GetBalance()}.");
                    isValid= true;
                }
                else if (balanceInput.ToLower() == "n" || balanceInput.ToLower() == "no")
                {
                    Console.WriteLine("Okay. Thank you for using our service!");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("I need a yes or no.");
                }
            } while (!isValid);
        }
    }
}
