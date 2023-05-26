namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"90 degrees Fahrenheit is {TempConverter.FahrenheitToCelcius(90)} degrees in Celcius.");
            Console.WriteLine($"0 degress Celcius is {TempConverter.CelciusToFahrenheit(0)} degrees in Fahrenheit.");
        }
    }
}
