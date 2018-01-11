using System;


namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
            }
            var reverseNumber = new int[n];
            for (int i =numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
