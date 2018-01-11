using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            PrintFactorialOF(number);
        }

        static void PrintFactorialOF(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
