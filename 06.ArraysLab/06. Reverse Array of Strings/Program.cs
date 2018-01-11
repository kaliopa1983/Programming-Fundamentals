using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine()
            .Split(' ')
            .ToArray();
            string[] reversedArr = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                reversedArr[text.Length - 1 - i] = text[i];
            }
            Console.WriteLine(String.Join(" ", reversedArr));
        }
    }
}
