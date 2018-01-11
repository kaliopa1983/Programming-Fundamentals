﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int number = int.Parse(commands[1]);
                    nums.RemoveAll(i => i == number);
                }
                else
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    nums.Insert(position, element);
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            if (commands[0] == "Odd")
            {
                foreach (var odd in nums)
                {
                    if (odd % 2 != 0)
                    {
                        Console.Write($"{odd} ");
                    }
                }
            }
            else
            {
                foreach (var even in nums)
                {
                    if (even % 2 == 0)
                    {
                        Console.Write($"{even} ");
                    }
                }
            }
        }
    }
}

