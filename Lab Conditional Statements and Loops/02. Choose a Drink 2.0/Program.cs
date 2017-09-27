using System;


namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = 0.0;
            if (profession== "Athlete")
            {
                price = 0.70;
            }
            else if((profession== "Businessman")||(profession== "Businesswoman"))
            {
                price = 1.00;
            }
            else if (profession== "SoftUni Student")
            {
                price = 1.70;
            }
            else
            {
                price = 1.20;
            }
            
            var totalPrice = price * quantity;

            Console.WriteLine("The {0} has to pay {1:f2}.", profession, totalPrice);
        }
    }
}
