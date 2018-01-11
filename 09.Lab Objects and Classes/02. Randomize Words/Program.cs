using System;

using System.Linq;


namespace _02.Randomize_Words
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                if (pos1!=pos2)
                {
                    var old = words[pos1];
                    words[pos1] = words[pos2];
                    words[pos2] = old;
                }
            }
            Console.WriteLine(String.Join("\r\n",words));
        }
    }
}
