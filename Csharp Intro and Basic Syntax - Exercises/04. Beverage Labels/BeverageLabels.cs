using System;


namespace _04.Beverage_Labels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string namesProduct = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentper100ml= int.Parse(Console.ReadLine());
            int sugarContentper100ml = int.Parse(Console.ReadLine());

            double energyContent = (volume * energyContentper100ml) / 100D;
            double sugarContent = (volume * sugarContentper100ml) / 100D;

            Console.WriteLine(volume+"ml"+" "+namesProduct+":");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
