using System;

namespace assignment_01
{
    public class FahrenheitToCelciusConverter
    {
        public double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public double CelciusToFahrenheit(double celcius)
        {
            return (celcius * 1.8) + 32;
        }
    }
}
