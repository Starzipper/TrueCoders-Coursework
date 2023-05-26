using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            // TODO:  Find the two Taco Bells that are the furthest from one another.
            // HINT:  You'll need two nested forloops ---------------------------

            logger.LogInfo("Log initialized");

            // use File.ReadAllLines(path) to grab all the lines from your csv file
            // Log and error if you get 0 lines and a warning if you get 1 line
            var lines = File.ReadAllLines(csvPath);
            if (lines.Length == 0)
            {
                logger.LogError("There are zero lines read from the file.");
            }
            else if (lines.Length == 1)
            {
                logger.LogWarning("There is only one line that has been read from the file.");
            }

            logger.LogInfo($"Lines: {lines.Length}");

            // Create a new instance of your TacoParser class
            var parser = new TacoParser();

            // Grab an IEnumerable of locations using the Select command: var locations = lines.Select(parser.Parse);
            var locations = lines.Select(parser.Parse).ToArray();

            // DON'T FORGET TO LOG YOUR STEPS

            // Now that your Parse method is completed, START BELOW ----------

            // TODO: Create two `ITrackable` variables with initial values of `null`. These will be used to store your two taco bells that are the farthest from each other.
            // Create a `double` variable to store the distance
            ITrackable tacoBell1 = null;
            ITrackable tacoBell2 = null;
            double farthestDistance = 0;

            // Include the Geolocation toolbox, so you can compare locations: `using GeoCoordinatePortable;`

            //HINT NESTED LOOPS SECTION---------------------
            // Do a loop for your locations to grab each location as the origin (perhaps: `locA`)

            // Create a new corA Coordinate with your locA's lat and long

            // Now, do another loop on the locations with the scope of your first loop, so you can grab the "destination" location (perhaps: `locB`)

            // Create a new Coordinate with your locB's lat and long

            // Now, compare the two using `.GetDistanceTo()`, which returns a double
            // If the distance is greater than the currently saved distance, update the distance and the two `ITrackable` variables you set above
            logger.LogInfo("Searching for the two Taco Bells that are farthest away from each other...");
            for (int i = 0; i < lines.Length; i++)
            {
                var originTacoBell = parser.Parse(lines[i]);
                GeoCoordinate origin = new GeoCoordinate()
                {
                    Latitude = originTacoBell.Location.Latitude,
                    Longitude = originTacoBell.Location.Longitude
                };
                for (int j = i + 1; j < lines.Length; j++)
                {
                    var comparedTacoBell = parser.Parse(lines[j]);
                    GeoCoordinate compared = new GeoCoordinate()
                    {
                        Latitude = comparedTacoBell.Location.Latitude,
                        Longitude = comparedTacoBell.Location.Longitude
                    };
                    if (origin.GetDistanceTo(compared) > farthestDistance)
                    {
                        farthestDistance = origin.GetDistanceTo(compared);
                        tacoBell1 = originTacoBell;
                        tacoBell2 = comparedTacoBell;
                    }
                }
            }
            logger.LogInfo($"Search done. The two Taco Bells that are farthest from each other are the {tacoBell1.Name} and the {tacoBell2.Name} with a distance of {farthestDistance}.");

            // Once you've looped through everything, you've found the two Taco Bells farthest away from each other.


            
        }
    }
}
