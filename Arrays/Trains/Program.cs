using System;
using System.Collections.Generic;
using System.Linq;

namespace Trains
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> train = new List<int>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                int people = int.Parse(Console.ReadLine());
                Console.Write($"{people} ");
                train.Add(people);
            }
            Console.WriteLine();
            Console.WriteLine(train.Sum());
        }
    }
}
