﻿using System;
using System.Collections.Generic;
namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            
            Dictionary<string,int> counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var results = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value%2!=0)
                {
                    results.Add(pair.Key);
                }
            }
           
                Console.WriteLine(string.Join(", ", results));

        }
    }
}
