﻿using System;


namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
          //  double dul, sh, V = 0;
            Console.Write("Length: ");
             double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
             double  width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
             double  height = double.Parse(Console.ReadLine());
          var volumeOFPyramid  = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volumeOFPyramid);


        }
    }
}
