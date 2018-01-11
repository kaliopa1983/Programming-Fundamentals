using System;
namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower(); 

            int count = 0;
            var index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index == -1)
                {
                    break;
                    
                }
                  count++;
                
            }
            Console.WriteLine(count);
        }
    }
}
