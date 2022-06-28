using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }
            }

            Console.WriteLine(sum);

        }
    }
}
