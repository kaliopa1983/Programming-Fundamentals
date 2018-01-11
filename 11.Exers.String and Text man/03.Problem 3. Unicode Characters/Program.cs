using System;

namespace _03.Problem_3.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for ( var i=0; i<input.Length;i++)
            {
                Console.Write("\\u{0:x4}", (int)input[i]);
            }
            Console.WriteLine();

        }
            
        }
    }
