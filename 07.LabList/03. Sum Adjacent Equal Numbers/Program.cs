using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> num = Console.ReadLine().Split(' ').Select(Double.Parse).ToList();
            bool hasSummed = true;

            while (hasSummed)
            {
                hasSummed = false;

                var index = 0;
                var sum = 0.0;
                for (int i = 1; i < num.Count; i++)
                {

                    if (num[i] == num[i - 1])
                    {
                        index = i - 1;
                        sum = num[i] + num[i - 1];
                        hasSummed = true;
                        break;
                    }

                }
                if (hasSummed)
                {
                num.RemoveRange(index, 2);
                num.Insert(index, sum);
                
                }
               
            }
            Console.WriteLine(String.Join(" ",num));
        }
    }

}