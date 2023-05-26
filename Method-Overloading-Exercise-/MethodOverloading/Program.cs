namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return (a + b);
        }

        public static double Add(double a, double b)
        {
            return (a + b);
        }

        public static string Add(int a, int b, bool isMoney)
        {
            if (isMoney && (a + b) > 1)
            {
                return ($"{a + b} dollars");
            }
            else if (isMoney && (a + b) == 1)
            {
                return ($"{a + b} dollar");
            }
            else
            {
                return ($"{a + b}");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2.23, 5.62));
            Console.WriteLine(Add(0, 1, true));
        }
    }
}
