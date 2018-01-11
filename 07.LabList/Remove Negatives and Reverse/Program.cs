using System;
using System.Collections.Generic;
using System.Linq;


namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

           
            
                foreach (var num in nums)
                {
                    if (num >= 0)
                    {
                        result.Add(num);
                        


                    }
                }

                if (result.Count < 1)
                {
                    Console.WriteLine("empty");
                }
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
        }



    }






