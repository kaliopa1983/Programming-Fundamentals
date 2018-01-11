using System;
using System.Linq;
using System.Numerics;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string wordOne = input[0];
            string wordTwo = input[1];

            var arrayOne = wordOne.ToCharArray().Distinct().ToArray();

            var arrayTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length==arrayTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
 