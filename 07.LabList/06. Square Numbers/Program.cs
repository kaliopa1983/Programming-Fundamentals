using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumber = new List<int>();
            foreach (var number in num)
            {
                if (Math.Sqrt(number)==(int)Math.Sqrt(number))
                {
                    squareNumber.Add(number);
                }
            }
             squareNumber.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ",squareNumber));
        }
    }
}
