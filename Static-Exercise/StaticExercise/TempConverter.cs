using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius (double fahrenheit)
        {
            return ((fahrenheit - 32.0) * (5.0/9.0));
        }
        public static double CelciusToFahrenheit (double celcius)
        {
            return (celcius * (9.0/5.0) + 32.0);
        }
    }
}
