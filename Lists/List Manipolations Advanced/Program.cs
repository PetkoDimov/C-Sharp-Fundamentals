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

            bool isChanged = false;

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        number.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "REMOVE":
                        number.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "REMOVEAT":
                        number.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "INSERT":
                        number.Insert(int.Parse(command[2]), (int.Parse(command[1])));
                        isChanged = true;
                        break;

                    case "CONTAINS":
                        Console.WriteLine(number.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                         break;

                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(" ", number
                            .Where(n=> n%2 == 0)));
                        break;

                    case "PRINTODD":
                        Console.WriteLine(string.Join(" ", number
                            .Where(n=> n %2 != 0)));
                        break;

                    case "GETSUM":
                        Console.WriteLine(number.Sum());
                        break;

                    case "FILTER":
                        string result = string.Empty;

                        switch (command[1])
                        {
                            case "<":
                                result = string.Join(" ", number
                                    .Where(n => n < int.Parse(command[2])));
                                break;

                            case "<=":
                                result = string.Join(" ", number
                                    .Where(n => n <= int.Parse(command[2])));
                                break;

                            case ">":
                                result = string.Join(" ", number
                                    .Where(n => n > int.Parse(command[2])));
                                break;

                            case ">=":
                                result = string.Join(" ", number
                                    .Where(n => n >= int.Parse(command[2])));
                                break;

                            default:
                                break;
                        }

                        Console.WriteLine(result);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions
                    .RemoveEmptyEntries);

            }
            if (isChanged)
            {

                Console.WriteLine(string.Join(" ", number));

            }
        }
    }
}
