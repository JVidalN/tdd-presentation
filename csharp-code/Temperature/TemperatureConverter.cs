using System;

namespace Temperature
{
    public static class TemperatureConverter
    {
        public static double FahrenheitToCelsius(double temperature)
        {
            //throw new NotImplementedException();
            return Math.Round((temperature - 32) / 1.8, 2);
        }
    }
}