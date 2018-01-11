using System;


namespace _07.Math_Power
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(2,3);
            Console.WriteLine(result);
        }

        static double RaiseToPower (double number,int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * number;
                return result;
            }
        }  
    }
}
