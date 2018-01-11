using System;
namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            var result = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int evenSum = SumEvenDigits(n);
            int oddSum = SumOddDigits(n);
            return (evenSum * oddSum);
        }

         static int SumOddDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigits = n % 10;
                if (lastDigits%2!=0)
                {
                    sum += lastDigits;
                }
                n = n / 10;
            }
            return ( sum);
        }

        static int SumEvenDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigits = n % 10;
                if (lastDigits%2==0)
                {
                    sum += lastDigits;
                }
                n = n / 10;
            }
            return (sum);
                
        }
    }
}
