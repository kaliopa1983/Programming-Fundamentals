using System;


namespace _06.Prime_Checker
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var IsPrime = IsPrimeNumber(n);
            Console.WriteLine(IsPrime);
        }

        static bool IsPrimeNumber(long n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n < 4)
            {
                return true;
            }
            if (n==4)
            {
                return false;
            }

            for (int i = 5; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}

