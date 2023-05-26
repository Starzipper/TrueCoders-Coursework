namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your favorite subject in school?");
            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("Same, I love math!");
                    break;
                case "english":
                    Console.WriteLine("Can't relate. I absolutely hate English.");
                    break;
                case "history":
                    Console.WriteLine("Eh, I always fell asleep in history. It's kinda boring.");
                    break;
                case "science":
                    Console.WriteLine("That's great! I love science of all kinds.");
                    break;
                case "literature":
                    Console.WriteLine("I always thought literature was a drag, but I guess it's alright.");
                    break;
                default:
                    Console.WriteLine("Oh, that's cool!");
                    break;
            }
        }
    }
}