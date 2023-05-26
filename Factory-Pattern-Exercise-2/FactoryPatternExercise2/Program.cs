namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? (List, SQL, or Mongo)");
            string userInput = InputChecker.MustMatch("List", "SQL", "Mongo");
            IDataAccess? newData = DataAccessFactory.GetDataAccess(userInput);
            newData.SaveData();
        }
    }
}
