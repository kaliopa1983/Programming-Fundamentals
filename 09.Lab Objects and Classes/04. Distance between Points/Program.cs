using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{   class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        
        double distance = CalcDistance(p1, p2);

        
        Console.WriteLine("Distance: {0:f3}", distance);

    }

        static double CalcDistance(Point p1, Point p2)
        {
           int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

         static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split()
      .Select(int.Parse).ToArray();
            Point point = new Point();
            point.x = pointInfo[0];
            point.y = pointInfo[1];
            return point;

        }
    }

   
}
