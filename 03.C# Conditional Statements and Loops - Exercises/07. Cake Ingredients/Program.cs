using System;


namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfingradients = 0;
            for (int i = 1; i <= 20; i++)
            {    
                var ingredient = Console.ReadLine();
                if (ingredient!="Bake!") 
                {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                numberOfingradients++;
                }
               
            else
            {         
                    Console.WriteLine($"Preparing cake with {numberOfingradients} ingredients.");
                    break;

            }


            }
        }
    }
}

