namespace CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            char[] firstPartChars = line[0].ToCharArray();
            char[] secondPartChars = line[1].ToCharArray();

            List<int> firstDecimals = new List<int>();
            List<int> secondDecimals = new List<int>();


            for (int i = 0; i < firstPartChars.Length; i++)
            {
                firstDecimals.Add(firstPartChars[i]);
            }
            for (int i = 0; i < secondPartChars.Length; i++)
            {
                secondDecimals.Add(secondPartChars[i]);
            }

            if (firstDecimals.Count == secondDecimals.Count)
            {
                int sum = 0;

                for (int i = 0; i < firstPartChars.Length; i++)
                {
                    int multiply = firstDecimals[i] * secondDecimals[i];
                    sum += multiply;
                }
                Console.WriteLine(sum);
            }
            else
            {
                int sum = 0;

                var minCount = Math.Min(firstDecimals.Count, secondDecimals.Count);
                var maxCount = Math.Max(firstDecimals.Count, secondDecimals.Count);

                for (int i = 0; i < minCount; i++)
                {
                    int multiply = firstDecimals[i] * secondDecimals[i];
                    sum += multiply;

                    firstDecimals.RemoveAt(i);
                    secondDecimals.RemoveAt(i);
                }

                for (int i = 0; i < maxCount - minCount; i++)
                {
                    if (firstDecimals.Count != 0 && secondDecimals.Count == 0)
                    {
                        sum += firstDecimals[i];
                    }
                    else if (secondDecimals.Count != 0 && firstDecimals.Count == 0)
                    {
                        sum += secondDecimals[i];
                    }

                    Console.WriteLine(sum);
                }
            }
        }
    }
}

