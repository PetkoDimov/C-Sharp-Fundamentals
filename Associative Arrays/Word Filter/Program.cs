using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
           .Split(" ")
           .Where(w => w.Length % 2 == 0).ToList();


            foreach (var item in input)
            {
                Console.WriteLine(item);
            }


        }
    }
}
