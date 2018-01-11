using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s|^)\b[a-zA-Z0-9]+([_.-][a-zA-Z0-9]+)*@[a-zA-Z]+(\-[a-zA-Z]+)*(\.[a-zA-Z]+(\-[a-zA-Z]+)*)+\b(?=\s|\.|$|\,)";

            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            for (int i = 0; i < matches.Count; i++)
            {
                Console.WriteLine(matches[i].Groups[0].Value.Trim());
            }
        }
    }
}
