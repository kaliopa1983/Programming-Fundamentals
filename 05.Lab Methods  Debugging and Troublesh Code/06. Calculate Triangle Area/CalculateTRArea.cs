using System;


namespace _06.Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           double area=(CalcTriangleArea(width, height));
            Console.WriteLine(area);

        }

         static double CalcTriangleArea(double width, double height)
        {
            return width * height / 2;

        }
    }
}
