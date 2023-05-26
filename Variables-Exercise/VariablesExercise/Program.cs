namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string catName = "Bruno";
            int catAge = 3;
            char nameStartsWith = 'b';
            bool isFixed = true;
            double runSpeed = 30.00;
            decimal catLength = 1.12m;

            Console.WriteLine($"My cat's name is {catName}, and he can run {runSpeed} miles per hour!" +
                $"\n He's {catAge} years old and about average size at {catLength} feet long." +
                $"\n It's pretty funny, all of our animals' names start with the letter {nameStartsWith}. Don't know how that happened, haha!");

            if (isFixed == true)
            {
                Console.WriteLine("Also, he's fixed!");
            }
            else
            {
                Console.WriteLine("He hasn't been fixed yet, by the way.");
            }
        }
    }
}
