using System;


namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var professional = Console.ReadLine();
            if (professional== "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if ( (professional== "Businessman" ) ||(professional== "Businesswoman"))
            {
                Console.WriteLine("Coffee");
            }
            else if(professional== "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
            
        }
    }
}
