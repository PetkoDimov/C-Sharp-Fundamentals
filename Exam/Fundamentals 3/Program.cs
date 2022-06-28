using System;
using System.Linq;
using System.Collections.Generic;

namespace Fundamentals_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdArg = commands[0];

                if (cmdArg == "Enroll")
                {
                    string name = commands[1];
                    if (heroes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(name, new List<string>());
                    }

                }
                else if (cmdArg == "Learn")
                {
                    string name = commands[1];
                    string spell = commands[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                        else
                        {
                            heroes[name].Add(spell);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }
                else if (cmdArg =="Unlearn")
                {
                    string name = commands[1];
                    string spell = commands[2];

                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            int index = heroes[name].IndexOf(spell);
                            heroes[name].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }

                }

                input = Console.ReadLine();
            }
            var sortedDic = new Dictionary<string, List<string>>();

            sortedDic = heroes.OrderByDescending(k => k.Value.Count).ThenBy(n => n.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            Console.WriteLine("Heroes:");

            foreach (var heroe in sortedDic)
            {
                Console.WriteLine($"== {heroe.Key}: {string.Join(", ", heroe.Value)}");

            }

        }
    }
}
