using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
   public class FoldandSum
    {
      public  static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;

            int[] leftArr = numbers.Take(k).ToArray();
            int[] middleArr = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                result[i] = middleArr[i] + leftArr[i];
                result[k + i] = middleArr[k + i] + rightArr[i];

            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
