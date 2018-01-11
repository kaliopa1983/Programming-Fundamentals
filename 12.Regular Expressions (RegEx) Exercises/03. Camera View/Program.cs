﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var pattern = $@"(?<=\|<)(?:[^|]{{{tokens[0]}}})([^|]{{0,{tokens[1]}}}).*?(?=$|\|<)";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            var list = new List<string>();
            foreach (Match item in matches)
            {
                list.Add(item.Groups[1].Value);
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
