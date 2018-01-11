using System;


namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float speedMpers = (distance /( (hours*3600.0f)+(minutes*60.0f)+seconds));
            float speedKmperh = (distance/1000.0f) /( hours+(minutes/60.0f)+(seconds/3600.0f));
            float speedMpperh =(distance/1609.0f) / (hours + (minutes / 60.0f) + (seconds / 3600.0f));

            Console.WriteLine("{0}",speedMpers);
            Console.WriteLine("{0}", speedKmperh);
            Console.WriteLine("{0}", speedMpperh);

        }
    }
}
