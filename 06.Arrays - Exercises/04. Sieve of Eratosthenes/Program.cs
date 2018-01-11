using System;
using System.Collections.Generic;

namespace _04.Sieve_of_Eratosthenes
{
   public class Program
    {
     public   static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];
            for (int i = 0; i <primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if(primes[i])
                {
                    for (int j =i*i; j < primes.Length; j+=i)
                    {
                        primes[j] = false;
                    }
                }
            }

            System.Collections.Generic.List<int> result = new List<int>();
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine($"{string.Join(" ",result)}");
        }
    }
}
