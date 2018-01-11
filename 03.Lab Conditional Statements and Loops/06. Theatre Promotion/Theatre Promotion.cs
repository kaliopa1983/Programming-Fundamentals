﻿using System;

namespace _06.Theatre_Promotion
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            var typeofday = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            if (typeofday == "weekday" )
            {
                if ((age>=0 && age <=18)||(age>64 && age<=122))
                {
                    price = 12;
                }
               else if (age>18 && age <=64)
                {
                    price = 18;
                }
            }
            else if (typeofday == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }
            else if (typeofday=="holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            if (price != 0)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
