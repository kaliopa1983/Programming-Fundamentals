using System;
using System.Linq;


namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            TypeSelector(array);

        }

        static void TypeSelector(int[] ar)
        {
            int n = ar.Length;
            if (n == 1)
            {
                One(ar);
            }
            else if (n % 2 == 0)
            {
                Even(ar);
            }
            else
            {
                Odd(ar);
            }
        }

        static void One(int[] arr)
        {
            Console.WriteLine(arr[0]);
        }

        static void Even(int[] arr)
        {
            Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}");
        }

        static void Odd(int[] arr)
        {
            Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]}");
        }
    }
}
    

