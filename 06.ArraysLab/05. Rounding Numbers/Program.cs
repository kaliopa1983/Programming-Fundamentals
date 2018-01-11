using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            double []num =Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            foreach (var x in num)
            {
                double roundedNum = Math.Round(x, 0,
                   MidpointRounding.AwayFromZero);
                Console.WriteLine($"{x} ->{roundedNum}");
            }
        }
    }
}
