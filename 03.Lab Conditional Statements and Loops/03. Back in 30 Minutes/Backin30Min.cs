using System;

namespace _03.Back_in_30_Minutes
{
    class Backin30Min
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine())+30; 
            if (minutes > 59) 
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23) 
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:{1:D2}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
            }
        }
    }

