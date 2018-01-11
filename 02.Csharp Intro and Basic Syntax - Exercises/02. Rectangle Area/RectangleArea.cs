using System;


namespace _02.Rectangle_Area
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var rectanglesArea = width * height;

            Console.WriteLine("{0:f2}", rectanglesArea);
        }
    }
}
