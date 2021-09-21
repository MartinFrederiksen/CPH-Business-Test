using System;
using Xunit;

namespace assignment_01.Tests
{
    public class FahrenheitToCelciusConverterTest
    {
        [Fact]
        public void Test1()
        {
            FahrenheitToCelciusConverter fahrenheitToCelciusConverter = new FahrenheitToCelciusConverter();
            // 10 celcius
            double result = fahrenheitToCelciusConverter.FahrenheitToCelcius(50);

            Assert.Equal(10, result);
        }

        [Fact]
        public void Test2()
        {
            FahrenheitToCelciusConverter fahrenheitToCelciusConverter = new FahrenheitToCelciusConverter();
            // 122 celcius
            double result = fahrenheitToCelciusConverter.CelciusToFahrenheit(50);

            Assert.Equal(122, result);
        }
    }
}
