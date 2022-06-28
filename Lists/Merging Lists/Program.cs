using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstNumber.Count, secondNumber.Count); i++)
            {
                result.Add(firstNumber[i]);
                result.Add(secondNumber[i]);
            }


            for (int i = Math.Min(firstNumber.Count, secondNumber.Count); i < Math.Max(firstNumber.Count, secondNumber.Count); i++)
            {
                if (i >= firstNumber.Count)
                {
                    result.Add(secondNumber[i]);
                }
                else
                {
                    result.Add(firstNumber[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
