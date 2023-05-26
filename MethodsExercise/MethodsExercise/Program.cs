namespace MethodsExercise
{
    public class Program
    {
        public static int Add(params int[] nums)
        {
            int sum = 0;
            for (int i=0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }

        public static int Multiply(params int[] nums)
        {
            int product = 1;
            for (int i=0; i < nums.Length; i++)
            {
                product = product * nums[i];
            }
            return product;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Add(70, 2, 3, 5, 10));
            Console.WriteLine(Multiply(1, 2, 3, 4));
            
            Console.WriteLine("Hello, my name is Fortuna Mystic. I'll be divining the prospects for your future.");
            Console.WriteLine("I'll need some details from you first.");

            Console.WriteLine("What's your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("What's your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var monthBorn = Console.ReadLine();

            Console.WriteLine($"So, your name is {userName}, your favorite color is {favColor}, and you were born in {monthBorn}...");
            Console.WriteLine("Let's see what your fortune is...");

            // Reading personality based on birth month
            if (monthBorn == "January" || monthBorn == "january")
            {
                Console.WriteLine("I see you are quite a bold and alert person...");
            }
            else if (monthBorn == "February" || monthBorn == "february")
            {
                Console.WriteLine("I see you are very loyal person... You also seem to have good luck.");
            }
            else if (monthBorn == "March" || monthBorn == "march")
            {
                Console.WriteLine("I see...you are a very smart yet mischievious person, aren't you?");
            }
            else if (monthBorn == "April" || monthBorn == "april")
            {
                Console.WriteLine("I see that you're a strong yet caring person... How admirable.");
            }
            else if (monthBorn == "May" || monthBorn == "may")
            {
                Console.WriteLine("I see...you're a practical person, yet still quite loving.");
            }
            else if (monthBorn == "June" || monthBorn == "june")
            {
                Console.WriteLine("I see that you're a curious and romantic person...");
            }
            else if (monthBorn == "July" || monthBorn == "july")
            {
                Console.WriteLine("I see you're and adventurous and honest person...");
            }
            else if (monthBorn == "August" || monthBorn == "august")
            {
                Console.WriteLine("I see that you're an active and hardworking person...");
            }
            else if (monthBorn == "September" || monthBorn == "september")
            {
                Console.WriteLine("I see that you're a sensitive and delicate person...");
            }
            else if (monthBorn == "October" || monthBorn == "october")
            {
                Console.WriteLine("I see that you're quite a friendly person...");
                Console.WriteLine("Also, you're outfit looks quite nice! I like it.");
            }
            else if (monthBorn == "November" || monthBorn == "november")
            {
                Console.WriteLine("I see that you are a kind-hearted and creative person...");
            }
            else if (monthBorn == "December" || monthBorn == "december")
            {
                Console.WriteLine("I see that you are a confident and free-spirited person...");
            }
            else
            {
                Console.WriteLine("I see...You are quite a mysterious person. It's hard to get a read on you...");
            }

            // Fortune reading based on favorite color
            if (favColor == "Red" || favColor == "red")
            {
                Console.WriteLine("I see that there is catastophe that is going to happen in your imminent future.");
                Console.WriteLine("Please be careful and stay safe.");
            }
            else if (favColor == "Orange" || favColor == "orange")
            {
                Console.WriteLine("I see...Soon you will discover a new part of yourself you were once unaware of.");
                Console.WriteLine("You're future will be a period of discovery, adventure, and exploring yourself.");
            }
            else if (favColor == "Yellow" || favColor == "yellow")
            {
                Console.WriteLine("I see...Nothing of particular note is going happen in your imminent future.");
                Console.WriteLine("Everything will continue according to your routine.");
            }
            else if (favColor == "Green" || favColor == "green")
            {
                Console.WriteLine("I see...A new romance will blossom soon in your future.");
            }
            else if (favColor == "Teal" || favColor == "teal" || favColor == "Turquoise" || favColor == "turquoise" || favColor == "Cyan" || favColor == "cyan")
            {
                Console.WriteLine("I see...Soon you will experience a great heartbreak.");
                Console.WriteLine("I see that a loved one of yours will exit your life soon, though I do not know by what means.");
            }
            else if (favColor == "Blue" || favColor == "blue")
            {
                Console.WriteLine("I see...Soon you will discover a new hobby you love.");
            }
            else if (favColor == "Indigo" || favColor == "indigo")
            {
                Console.WriteLine("I see...You will win the lottery next week.");
            }
            else if (favColor == "Purple" || favColor == "purple")
            {
                Console.WriteLine("I see...You will get a promotion in the near future.");
            }
            else if (favColor == "Pink" || favColor == "pink")
            {
                Console.WriteLine("I see...Soon you will be betrayed by someone close to you.");
            }
            else if (favColor == "White" || favColor == "white")
            {
                Console.WriteLine("I see...Soon you will become close friends with someone new.");
            }
            else if (favColor == "Black" || favColor == "black")
            {
                Console.WriteLine("I see...Soon you will lose a great sum of money.");
            }
            else
            {
                Console.WriteLine("Strange...I don't see anything in your future. Perhaps that doesn't bode well?");
                Console.WriteLine("Please stay safe and be careful on your way home.");
            }

            Console.WriteLine("");
            Console.WriteLine($"Thank you for visiting my fortune telling shop, {userName}. I hope to see you again. Take care.");
        }
    }
}
