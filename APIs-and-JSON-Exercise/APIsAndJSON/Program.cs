using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            for (int i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                Console.WriteLine($"Kanye: {kanyeQuote}");
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();
                Console.WriteLine($"Ron: {ronQuote}");
            }
            Console.WriteLine("");
            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?lat=30.48&lon=-87.69&appid=2107d2414f2061df5b92fede9fa44b5c&units=imperial";
            var weather = client.GetStringAsync(weatherURL).Result;
            var weatherTemp = JObject.Parse(weather).GetValue("main").ToString().Replace('}', ' ').Trim().Replace('{', ' ');
            Console.WriteLine("Weather in Summerdale right now: ");
            Console.WriteLine(weatherTemp);
        }
    }
}
