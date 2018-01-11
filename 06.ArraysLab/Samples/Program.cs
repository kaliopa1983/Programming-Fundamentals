using System;

namespace Samples
{
    class Program
    {
        static void Main()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            var days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (dayNumber>=1 && dayNumber<=7)
            {
               
                Console.WriteLine(days[dayNumber-1]);
            }
            else
            {
                Console.WriteLine(" Invalid Day! ");
            }
        }
    }
}
