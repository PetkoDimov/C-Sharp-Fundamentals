using System;
using System.Linq;

namespace Zig_Zag_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArr = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string index0 = currentArr[0];
                string index1 = currentArr[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = index0;
                    secondArr[i] = index1;
                }

                else if (i % 2 == 1)
                {
                    firstArr[i] = index1;
                    secondArr[i] = index0;
                }

            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));

        }
    }
}
