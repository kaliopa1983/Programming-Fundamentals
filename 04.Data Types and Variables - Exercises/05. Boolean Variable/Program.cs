using System;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Convert.ToBoolean(text);
            if ( text =="True")
            {
                Console.WriteLine("Yes");
            }
            else if (text =="False")
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
