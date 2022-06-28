using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product."
            ,"Such a great product."
            ,"I always use that product."
            ,"Best product of its category."
            ,"Exceptional product."
            ,"I can't live without this product."};

            string[] events = { "Now I feel good."
            ,"I have succeeded wuth this product."
            ,"Makes miracles. I am happy of the results!"
            ,"I cannot beleive but now I feel awesome."
            ,"Try it yourself, I am very satisfied."
            ,"I feed great!"};

            string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                string message = phrases[rnd.Next(0, phrases.Length)];
                string place = events[rnd.Next(0, events.Length)];
                string autor = autors[rnd.Next(0, autors.Length)];
                string city = cities[rnd.Next(0, cities.Length)];

                Console.WriteLine($"{message} {place} {autor} {city}.");
            }
        }
    }
}
