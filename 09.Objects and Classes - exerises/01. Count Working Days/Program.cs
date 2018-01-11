﻿using System;

using System.Globalization;


namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays =
             {
            DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),

            DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture)
              };

                  int countOfWorkigDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isnotHoliday = true;
                    foreach (var holiday in holidays)
                    {
                        if (holiday.Day==currentDate.Day&&holiday.Month==currentDate.Month)
                        {
                            isnotHoliday = false;
                            break;
                        }
}

                       if (isnotHoliday)
                      {
                       countOfWorkigDays++;
                      }
                    
                }

            }
            Console.WriteLine(countOfWorkigDays);
        }
    }
}


