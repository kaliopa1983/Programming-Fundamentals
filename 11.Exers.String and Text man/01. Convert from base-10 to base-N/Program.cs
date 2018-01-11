using System;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main()
        {
            BigInteger[] read = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseN = read[0];
            BigInteger number = read[1];
            BigInteger remainder;
            string result = string.Empty;
            if (baseN >= 2 && baseN <= 10)
            {
                while (number > 0)
                {
                    remainder = number % baseN;
                    number /= baseN;
                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
