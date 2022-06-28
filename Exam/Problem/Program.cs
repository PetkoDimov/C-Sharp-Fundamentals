using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string command = Console.ReadLine();
            

            while (command != "End")
            {
                string[] tokens = command.Split(" ");
                string cmdArg = tokens[0];

                if (cmdArg == "Translate")
                {
                    string charachter = tokens[1];
                    string replacement = tokens[2];
                    input = input.Replace(charachter, replacement);
                    Console.WriteLine(input);

                }
                else if (cmdArg == "Includes")
                {
                    string contains = tokens[1];
                    if (input.Contains(contains))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (cmdArg == "Start")
                {
                    string start = tokens[1];
                    if (input.StartsWith(start))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmdArg == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (cmdArg == "FindIndex")
                {
                    string character = tokens[1];
                    Console.WriteLine(input.LastIndexOf(character));

                }
                else if (cmdArg == "Remove")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);

                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);

                }


                command = Console.ReadLine();
            }
        }
    }
}
