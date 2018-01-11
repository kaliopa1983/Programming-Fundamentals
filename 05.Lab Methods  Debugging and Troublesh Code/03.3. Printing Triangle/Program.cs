using System;

namespace _03._3.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFirstHalf( 0, n);
            PrintMidleLine(1,n);
            PrintSecondHalf(n,0);

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
                
            }
            Console.WriteLine();
        }
        static void PrintFirstHalf(int start,int n)

        {
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
        }
        static void PrintMidleLine(int start,int n)
        {
            PrintLine(1, n);
        }
        static void PrintSecondHalf(int n,int end)
        {
            for (int i = n-1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
