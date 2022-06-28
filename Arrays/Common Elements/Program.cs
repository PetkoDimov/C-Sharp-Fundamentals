using System;
using System.Linq;
using System.Collections.Generic;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> firstList = Console.ReadLine().
                Split(" ")
                .ToList();
            List<string> secondList = Console.ReadLine().
                Split(" ")
                .ToList();

            foreach (var item in firstList)
            {

                if (secondList.Contains(item))
                {
                    Console.Write($"{item} ");
                }

            }


        }
    }
}
