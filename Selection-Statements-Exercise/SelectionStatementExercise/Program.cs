namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();
            var favNumber = randomNumber.Next(1, 1000);
            int userInput;
            bool gameActive = true;

            Console.WriteLine("Hello! Can you guess my favorite number?");
            while (gameActive)
                {
                userInput = int.Parse(Console.ReadLine());

                if (userInput == favNumber)
                {
                    Console.WriteLine("That's right! Congratulations, you win!");
                    gameActive = false;
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("What?");
                }

                }
        }
    }
}
