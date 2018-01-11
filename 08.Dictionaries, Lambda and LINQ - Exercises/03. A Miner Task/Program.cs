﻿using System;
using System.Collections.Generic;


namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, long> metali = new Dictionary<string, long>();

            while (true)

            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());
                if (!metali.ContainsKey(input))
                {
                    metali.Add(input, 0);
                }
                metali[input] += quantity;

            }   
                foreach (var pair in metali)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }

            }

        }
    }


