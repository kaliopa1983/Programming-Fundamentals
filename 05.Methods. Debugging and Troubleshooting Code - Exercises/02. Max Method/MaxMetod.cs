using System;
namespace _02.Max_Method
{
  public static  class MoreMath
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int maxNum = Math.Max( a, Math.Max( b,  c));
            Console.WriteLine(maxNum);
        }

        public static int Max(int a, int b)
        {
            return Math.Max(a, b);
                
        }
        public static int Max(int a , int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));

        }
    }
} 



