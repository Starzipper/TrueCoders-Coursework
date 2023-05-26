namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
        static void Main(string[] args)
        {
            // Exercise One
            int a = 5;
            int b = 10;
            int quotient = b / a;
            int remainder = b % a;

            Console.WriteLine($"{b}+{a}={b+a}");
            Console.WriteLine($"{b}-{a}={b-a}");
            Console.WriteLine($"{b}*{a}={b*a}");
            Console.WriteLine($"{b}/{a}={quotient} with a remainder of {remainder}");

            // Exercise Two

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}.");
        }
    }
}
