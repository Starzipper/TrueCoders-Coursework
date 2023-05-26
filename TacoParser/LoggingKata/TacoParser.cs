namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("Parse failed. There are less than three elements in the array.", null);
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            // grab the longitude from your array at index 1
            // grab the name from your array at index 2

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            bool isLatitudeParsed = double.TryParse(cells[0], out double latitude);
            bool isLongitudeParsed = double.TryParse(cells[1], out double longitude);
            string name = cells[2];

            if (!isLatitudeParsed || !isLongitudeParsed)
            {
                logger.LogError("Location failed to parse.", null);
                return null;
            }

            var location = new Point()
            {
                Longitude = longitude,
                Latitude = latitude
            };

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var tacoBell = new TacoBell()
            {
                Name = name,
                Location = location
            };

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell;
        }
    }
}