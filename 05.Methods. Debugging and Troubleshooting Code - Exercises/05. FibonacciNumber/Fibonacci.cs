using System;
namespace _05.FibonacciNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n==0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fibonacci(n));
            }
            
        }
       static int Fibonacci(int number)
        {
            var f1 = 0;
            var f2 = 1;
            var fNext = 0;
            for (int i = 1; i <= number; i++)
            {
                fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }
                return fNext;
             
        }
    }
}
