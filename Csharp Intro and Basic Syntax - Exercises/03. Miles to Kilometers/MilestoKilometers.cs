using System;


namespace _03.Miles_to_Kilometers
{
    class MilestoKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double km = miles * 1.60934;

            Console.WriteLine("{0:f2}",km);
        }
    }
}
