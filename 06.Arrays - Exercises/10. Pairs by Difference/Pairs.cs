using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    class Pairs
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[i] - numbers[j] == difference || numbers[j] - numbers[i] == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
