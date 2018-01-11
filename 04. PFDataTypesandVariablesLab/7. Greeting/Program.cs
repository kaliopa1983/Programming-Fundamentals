using System;

namespace _7.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());


            

            Console.WriteLine($" Hello, {firstname} {lastname}. You are {age} years old.");
        }
    }
}
