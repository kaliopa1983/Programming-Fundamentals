using System.IO;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
           
            for (int i = 0; i <lines.Length; i++)
            {
                lines[i] = (i + 1) + ". " + lines[i];

            }


            File.WriteAllLines("output.txt", lines);


        }
    }
}


