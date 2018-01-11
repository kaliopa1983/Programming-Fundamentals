using System;
using  System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("words.txt").ToLower();
            string[]words = text
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
   StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
            List<KeyValuePair<string,int>>result= 
            wordCounts.OrderByDescending(wordCount => wordCount.Value).ToList();

            List<string> resultLines = result
                .Select(keyValue => keyValue.Key + "->" + keyValue.Value)
                .ToList();

            List<string> orderedWords = result
              .Select(keyValue => keyValue.Key)
              .ToList();

            File.WriteAllText("words.txt", String.Join(" ", orderedWords));
            File.WriteAllLines("result.txt", resultLines);
        }
    }
}
