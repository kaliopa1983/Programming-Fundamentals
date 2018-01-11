using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Count_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] counts = new int[(numbers.Max() + 1)];
            foreach (var num in numbers)
            {
                counts[num]++;
            }
            for (int i = 0; i <counts.Length; i++)
            {
                if (counts[i]>0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
