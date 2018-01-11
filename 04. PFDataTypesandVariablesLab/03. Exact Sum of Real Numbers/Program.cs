using System;


namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0.0M;
            for (int i = 1; i <= n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }
    }
}
