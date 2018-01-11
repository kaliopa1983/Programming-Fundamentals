using System;


namespace Arrays___Exercises
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

           int leftCount= FindMaxCommonItems(firstArr,secondArr);
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            int rigthCount= FindMaxCommonItems(firstArr, secondArr);
            Console.WriteLine($"{Math.Max(leftCount,rigthCount)}");
        }

        private static int FindMaxCommonItems(string[]firstArr, string[]secondArr)
        {
            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}


