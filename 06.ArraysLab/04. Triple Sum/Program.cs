using System;
using System.Linq;
namespace _04.Triple_Sum
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] arr = new int[input.Length];



            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

           bool tripleExist = false;

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            Console.WriteLine("{0} + {1} == {2}", arr[a], arr[b], arr[c]);
                           tripleExist = true;
                            break;
                        }
                    }
                }
            }


            if (!tripleExist)
            {
                   Console.WriteLine("No");
            }
                
                   
                    
                }

            }
        
    
        
    
}


