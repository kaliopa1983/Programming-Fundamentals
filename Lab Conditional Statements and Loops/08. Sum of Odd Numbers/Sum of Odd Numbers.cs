using System;
namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n*2; i++)
            {
                if (i%2!=0)
                {
                   Console.WriteLine(i);
                    sum += i;
                }
               
                
            }
            Console.WriteLine("Sum: "+sum);
        }
    }
}
