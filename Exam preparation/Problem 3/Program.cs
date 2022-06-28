using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
                                                                              //name             //meal  //count
            Dictionary<string, List<string>> like = new Dictionary<string, List<string>>();

            int unlikedMeals = 0;

            while (input != "Stop")
            {
                string[] command = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string cmdArg = command[0];
                if (cmdArg == "Like")
                {

                    string name = command[1];
                    string meal = command[2];
                    if (like.ContainsKey(name))
                    {
                        like[name].Add(meal);
                    }
                    else
                    {
                        like.Add(name, new List<string>() { meal });
                    }

                }
                else if (cmdArg == "Unlike")
                {
                    string name = command[1];
                    string meal = command[2];

                    if (like.ContainsKey(name))
                    {

                        if (!like[name].Contains(meal))
                        {
                            Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            string disliked = like[name].ToString();
                            int indexOfMeal = like[name].IndexOf(meal);
                            like[name].RemoveAt(indexOfMeal);
                            Console.WriteLine($"{name} doesn't like the {meal}");
                            unlikedMeals++;
                        }
                    }
                    else if (!like.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }

                }

                input = Console.ReadLine();

            }

            var meals = like.Values.ToList();
            foreach (var name in like)
            {

                Console.WriteLine($"{name.Key}: {string.Join(", ", name.Value)}");

            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");

        }
    }
}
