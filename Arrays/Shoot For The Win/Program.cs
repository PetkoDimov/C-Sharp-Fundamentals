﻿using System;
using System.Linq;

namespace Shoot_For_The_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            int count = 0;

            while (input?.ToUpper() != "END")
            {

                int index = int.Parse(input);

                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {

                    input = Console.ReadLine();
                    continue;
                }

                int shotTarget = targets[index];
                targets[index] = -1;
                count++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > shotTarget)
                    {
                        targets[i] -= shotTarget;
                    }
                    else
                    {
                        targets[i] += shotTarget;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}
