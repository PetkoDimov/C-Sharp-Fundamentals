using System;
using System.Linq;

namespace Fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "For Azeroth")
            {
                string[] tokens = command.Split(" ");
                string cmdArg = tokens[0];

                if (cmdArg == "GladiatorStance")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }

                else if (cmdArg == "DefensiveStance")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }

                else if (cmdArg == "Dispel")
                {
                    int index = int.Parse(tokens[1]);
                    char letter = char.Parse(tokens[2]);

                    if (letter == '\0')
                    {
                        Console.WriteLine("Dispel too weak.");
                    }

                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Replace(input[index], letter);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }

                else if (cmdArg == "Target")
                {

                    string cmdArg2 = tokens[1];

                    if (cmdArg2 == "Change")
                    {
                        string substring = tokens[2];
                        string secondSubstring = tokens[3];
                        input = input.Replace(substring, secondSubstring);
                        Console.WriteLine(input);
                    }

                    else if (cmdArg2 == "Remove")
                    {

                        string substring = tokens[2];
                        input = input.Replace(substring, "");
                        Console.WriteLine(input);

                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }

                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                command = Console.ReadLine();
            }

        }
    }
}
