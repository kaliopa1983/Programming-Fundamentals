﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    class Program
    {
        static void Main() 
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();
            
            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
        }

        static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rect = new Rectangle();
            rect.Left = input[0];
            rect.Top = input[1];
            rect.Width = input[2];
            rect.Height = input[3];
            return rect;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top + Height; } }

        public int CalcArea()
        {
            return Width * Height;
        }
       
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}