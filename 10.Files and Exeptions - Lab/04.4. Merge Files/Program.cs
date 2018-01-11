
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

namespace _04._4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = File.ReadAllText("input1.txt").Split();
            string[] second = File.ReadAllText("input2.txt").Split('\r', '\n');
            File.WriteAllText("result.txt", "");
            for (int i = 0; i < first.Length; i++)
            {
                File.AppendAllText("result.txt", first[i] + "\r\n" + second[i]);
            }


        }
    }
}

