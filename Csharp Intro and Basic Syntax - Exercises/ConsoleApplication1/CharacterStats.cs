using System;


namespace ConsoleApplication1
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealtht = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Health: " + new string ('|',currentHealth+1)+
                new string('.',maxHealtht-currentHealth)+ "|");
            Console.WriteLine("Energy: "+ new string ('|',currentEnergy+1)+
                new string('.',maxEnergy-currentEnergy)+ "|");


        }
    }
}
