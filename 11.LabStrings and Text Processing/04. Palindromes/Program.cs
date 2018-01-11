using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ',', '.', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            List<string> palendrom = new List<string>();
            foreach (var word in text)
            {
                if (word.SequenceEqual(word.Reverse()))

                {
                    palendrom.Add(word);
                }


            }

            Console.WriteLine(string.Join(", ", palendrom.OrderBy(x => x).Distinct()));

        }

    }
}



        