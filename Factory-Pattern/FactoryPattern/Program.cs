namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            int numWheels = InputChecker.ParseToInt();
            IVehicle newVehicle = VehicleFactory.GetVehicle(numWheels);
            newVehicle.Drive();
        }
    }
}
