using System;
using System.Linq;

namespace _04.NuminReverOrder
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();

            Console.WriteLine(ReverdOrder(input));
        }
        static string ReverdOrder (string text)
        {
            return string.Join("", text.Reverse());
        }
    }
}
