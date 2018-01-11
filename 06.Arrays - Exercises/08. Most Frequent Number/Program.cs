using System;

using System.Linq;


namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] count = new int[65536];

            foreach (int num in array)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxValue)
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
        }
    }
}