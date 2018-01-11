using System;


namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //perimeter, area and diagonal by given its width and height

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeterRectangle = 2.0*(width + height);
            double areaRectangle = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(perimeterRectangle);
            Console.WriteLine(areaRectangle);
            Console.WriteLine(diagonal);

        }
    }
}
