using System;

using System.Globalization;


namespace _01.Day_of_Week
{
    class Program
    {
        static void Main()
        {
            string dateAsText = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(dateAsText, "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
