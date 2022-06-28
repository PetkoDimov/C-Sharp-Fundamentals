using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isEqual = false;

            for (int i = 0; i <= array1.Length - 1; i++)
            {
                sum = sum + array1[i];

                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isEqual = false;
                    break;
                }
                else
                {
                    isEqual = true;
                }

            }

            if (isEqual == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }

        }
    }
}
