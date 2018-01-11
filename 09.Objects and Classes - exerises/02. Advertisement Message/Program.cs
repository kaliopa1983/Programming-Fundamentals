using System;


namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = {"Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();


            for (int i = 1; i <= n; i++)
            {
                int randomPhrases = rnd.Next(0, phrases.Length);
                int randomEvents = rnd.Next(0, events.Length);
                int randomAuthors = rnd.Next(0, authors.Length);
                int randomCities = rnd.Next(0, cities.Length);


                Console.WriteLine($"{phrases[randomPhrases]} {events[randomEvents]} {authors[randomAuthors]} - { cities[randomCities]}.");
            }
        }

    }
}


