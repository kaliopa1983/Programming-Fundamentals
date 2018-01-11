using System;


namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                var product = number * i;
                Console.WriteLine($"{number } X {i } = {product}");
            }
        }
    }
}
