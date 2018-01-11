using System.IO;
using System.Linq;
using System;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] oddLines =
                lines
                .Where((line,i) => i % 2 != 0)
                .ToArray();
            File.WriteAllLines("otput.txt",oddLines);
        }
    }
}
