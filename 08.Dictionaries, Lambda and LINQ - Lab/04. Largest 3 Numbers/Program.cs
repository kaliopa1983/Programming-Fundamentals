using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sortedNumbers = numbers.OrderByDescending(x => x);
            var largest3Numbers = sortedNumbers.Take(3);

            Console.WriteLine(String.Join(" ", largest3Numbers));
        }
    }
}
