using System;


namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var toHesa= Convert.ToString(number, 16).ToUpper();
           var ToBynary = Convert.ToString(number, 2).ToUpper();

            Console.WriteLine(toHesa);
            Console.WriteLine(ToBynary);




        }
    }
}
