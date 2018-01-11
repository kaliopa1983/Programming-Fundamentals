using System;


namespace LabStrings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = text.Length-1; i >=0; i--)
            {
                
                Console.Write(text[i]);
            }
            Console.WriteLine();
            
        }
    }
}
