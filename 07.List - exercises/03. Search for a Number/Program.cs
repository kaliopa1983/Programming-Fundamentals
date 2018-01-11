using System;
using System.Linq;


namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

           var arrayOfThreeNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstNumber = arrayOfThreeNumbers[0];
            int secondNumber = arrayOfThreeNumbers[1];
            int thirdNumber = arrayOfThreeNumbers[2];

            var saveNewNumbers = numbers.Take(firstNumber).ToList();
            saveNewNumbers.RemoveRange(0, secondNumber);

            if (saveNewNumbers.Contains(thirdNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

    }
    }

