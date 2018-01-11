using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    public class RotateandSum
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var n = input.Length;
           
            
            int k = int.Parse(Console.ReadLine());

             int[] sum = new int[n];
            

            for (int i = 0; i < k; i++)
            {
                int lastElement=input[ n-1];

                for (int j = n-1; j >0; j--)
                {
                    input[j] = input[j - 1];
                    sum[j] += input[j];
                }
                input[0] = lastElement; // first element
                sum[0] += input[0];


            }

            Console.WriteLine($"{string.Join(" ", sum)}");

        }
    }
}


