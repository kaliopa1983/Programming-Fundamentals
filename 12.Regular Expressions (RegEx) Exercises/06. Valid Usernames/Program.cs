using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            string splittingRegex = @"(?:(?:[\/\\() ]+?)|^)(.*?)(?=$| |\/|\\|\(|\))";
            string nameRegex = @"^([a-zA-Z][\w]{2,24})$";
            var names = Regex.Matches(text, splittingRegex);
            var cleanList = new List<string>();
            foreach (Match name in names)
            {
                var nameMatch = Regex.Match(name.Groups[1].Value, nameRegex);
                if (nameMatch.Success)
                {
                    cleanList.Add(nameMatch.Groups[1].Value);
                }
            }
            

            int maxSum = 0;
            int ind1 = -1;
            int ind2 = -1;
            for (int i = 1; i < cleanList.Count; i++)
            {
                int sum = cleanList[i - 1].Length + cleanList[i].Length;
                if (sum > maxSum)
                {
                    ind1 = i - 1;
                    ind2 = i;
                    maxSum = sum;
                }
            }
            Console.WriteLine(cleanList[ind1]);
            Console.WriteLine(cleanList[ind2]);
          
        }
    }
}
