using System;
namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countCheese = 0;
            int countTomato = 0;
            int countSalami = 0;
            int countPepper = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese") countCheese++;
                if (ingredient == "tomato sauce") countTomato++;
                if (ingredient == "salami") countSalami++;
                if (ingredient == "pepper") countPepper++;
            }
            Console.WriteLine($"Total calories: {countCheese * 500 + countTomato * 150 + countSalami * 600 + countPepper * 50}");
        }
    }
}


           