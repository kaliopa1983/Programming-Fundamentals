using System;


namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

         static void PrintSign(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if(number==0)
            {
                Console.WriteLine("The number 0 is zero.");
            }

        }
    }
}
