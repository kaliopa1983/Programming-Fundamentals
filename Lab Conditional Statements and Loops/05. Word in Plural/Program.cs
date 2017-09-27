using System;


namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string singleWord = Console.ReadLine();

            if(singleWord.EndsWith("y"))
            {
                singleWord = singleWord.Remove(singleWord.Length - 1);
                singleWord += "ies";
            }
           
                
            else if ((singleWord.EndsWith("o"))|| (singleWord.EndsWith("ch"))|| (singleWord.EndsWith("s"))
               || (singleWord.EndsWith("sh"))|| (singleWord.EndsWith("x"))|| (singleWord.EndsWith("z")))
            {
                singleWord += "es";
            }
            else
            {
                singleWord += "s";
            }
            Console.WriteLine(singleWord);
        }
    }
}
