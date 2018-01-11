using System;


namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Centuries =");
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = 60 * hours;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries,years,days,hours,minutes);

        }
    }
}
