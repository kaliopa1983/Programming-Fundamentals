using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
           
          List<string>words = Console.ReadLine()
                .ToLower()
                .Split(new char[]
           {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '},StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var smallWords = new List<string>();
            foreach (var word in words)
            {
                if (word.Length < 5)
                {
                    smallWords.Add(word);
                }

            }

            var result = smallWords
                .OrderBy(x => x)
                .Distinct();

            Console.WriteLine(String.Join(", ", result));
                  
                    


            }
        }
    }


