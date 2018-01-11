using System;


namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            do
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");

                    i++;
                }
                else
                {


                    Console.WriteLine("The number is: {0}",Math.Abs(number));
                    break;
                }
               
            }
            while (i <= 10);

                

           
               
                
            
        }
    }
}
