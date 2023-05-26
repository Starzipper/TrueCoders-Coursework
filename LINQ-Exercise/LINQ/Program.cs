namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Stardew Valley", "Recettear", "Danganronpa", "Halo", "Fallout", "Portal"};
            foreach (string game in videoGames.OrderBy(game => game.Length))
            {
                Console.WriteLine(game);
            }
        }
    }
}
