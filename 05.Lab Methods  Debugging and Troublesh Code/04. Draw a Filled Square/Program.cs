using System;


namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow( n);
            Console.WriteLine();
            PrindMiddleRow(n);
            PrindMiddleRow(n);
            Console.WriteLine();
            PrintHeaderRow(n);

        }

         static void PrindMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
    }
}
