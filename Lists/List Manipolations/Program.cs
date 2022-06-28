using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipolations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        number.Add(int.Parse(command[1]));
                        break;

                    case "REMOVE":
                        number.Remove(int.Parse(command[1]));
                        break;

                    case "REMOVEAT":
                        number.RemoveAt(int.Parse(command[1]));
                        break;

                    case "INSERT":
                        number.Insert(int.Parse(command[2]),( int.Parse(command[1])));
                        break;


                    default:
                        break;
                }
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions
                    .RemoveEmptyEntries);

            }

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
