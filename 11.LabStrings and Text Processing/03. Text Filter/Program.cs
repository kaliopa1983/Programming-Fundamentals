using System;


namespace _03.Text_Filter
{
    class Program
    {
        static void Main()
        {


            string[] banWords = Console.ReadLine()
             .Split(new char[] {'.',',',' '},StringSplitOptions.RemoveEmptyEntries); 
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,
                      new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);

        }
    }
}

