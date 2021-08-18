using System;
using Xunit;

namespace Temperature.tests
{
    public class TemperatureConverterTests
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(47, 8.33)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(120.18, 48.99)]
        [InlineData(212, 100)]
        public void TestsTemperatureConversor(double fahrenheit, double celsius)
        {
            double calculateVal = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
            Assert.Equal(celsius, calculateVal);
        }
    }
}
