using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] oddLines = lines
                .Where((line, i) => i % 2 == 1)
                .ToArray();
            File.WriteAllLines("output.txt", oddLines);
        }
    }
}
