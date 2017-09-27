using System;



namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfpeople = int.Parse(Console.ReadLine());
            var servicePackage = Console.ReadLine();
            var priceHall = 0.0;
            var priceTotal = 0.0;
            var discountPercent = 0.0;
            var hallType = "";

            if (countOfpeople > 120)
            {

                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (countOfpeople<=50)
            {
                hallType = "Small Hall";
                    priceHall = 2500;
            }
            else if (countOfpeople<=100)
            {
                 hallType="Terrace";
                priceHall = 5000;
            }
            else if (countOfpeople<=120)
            {
                hallType = "Great Hall";
                priceHall = 7500;
            }
            
           
              
            if (servicePackage=="Normal")
            {
                 priceTotal = priceHall + 500;
                discountPercent = 0.05;
            }
            else if(servicePackage=="Gold")
            {
                 priceTotal = priceHall + 750;
                discountPercent = 0.1;
            }
            else if(servicePackage== "Platinum")
            {
                 priceTotal = priceHall + 1000;
                discountPercent = 0.15;
            }

            var discount = priceTotal - (priceTotal*discountPercent);
            var pricePerperson = discount / countOfpeople;

            Console.WriteLine($"We can offer you the {hallType}");
            Console.WriteLine("The price per person is {0:f2}$",pricePerperson);
             
           

            
        }
    }
}
