using System;


namespace _01.Debit_Card_Number1
{
    class DebitCardNumber1
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            Console.Write($"{number1:D4} {number2:D4} {number3:D4} {number4:D4}");
        }
    }
}
