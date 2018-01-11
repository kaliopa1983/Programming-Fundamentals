using System;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var kWord = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = $@"(?<=^|\!|\.|\?)([^!?.]*?\b{kWord}\b[^!?.]*?)((?=\!|\.|\?))";
            var matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[0].Value.Trim());
            }
        }
    }
}
