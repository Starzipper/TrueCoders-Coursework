namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Kia";
            myCar.Model = "Soul";
            myCar.Year = 2020;

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}! \n Unfortunately, I totalled it last December. Unironically, actually. :(");
        }
    }
}
