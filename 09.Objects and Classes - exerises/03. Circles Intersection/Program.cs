﻿using System;
using System.Linq;

namespace Circles_Intersection
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double DistanceTo(Point p)
        {
            double deltaX = Math.Abs(X - p.X);
            double deltaY = Math.Abs(Y - p.Y);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public class Circles_Intersection
    {
        public static void Main()
        {
            Circle circleA = GetCircle();
            Circle circleB = GetCircle();
            bool circlesIntersect = circleA.Center.DistanceTo(circleB.Center) <=
                                    circleA.Radius + circleB.Radius;
            if (circlesIntersect == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }

        private static Circle GetCircle()
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Point center = new Point() { X = input[0], Y = input[1] };
            Circle circle = new Circle() { Center = center, Radius = input[2] };
            return circle;
        }
    }
}