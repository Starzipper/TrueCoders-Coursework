using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            xmas.Santa = "Kris Kringle";

            xmas.Presents =  new string[3]{ "shoestring", "fishing string", "sewing string"}; 

            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
