﻿using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <=n; i++)
            {
                f=f*i;
            }
            Console.WriteLine(f);
        }
    }
}
