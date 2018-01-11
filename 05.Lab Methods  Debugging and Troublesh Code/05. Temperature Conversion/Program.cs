using System;


namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main()
        {
            double farenheit = double.Parse(Console.ReadLine());
            double celsius = FarenheitToCelsius(farenheit);
            Console.Write("Temperature in Celsius: {0:F2}", celsius);
        }
        static double FarenheitToCelsius(double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;

        }
    }
}
