﻿using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {

                    field[currentIndex] = 1;

                }

            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split(" ");
                int ladyBugIndex = int.Parse(elements[0]);
                string directions = elements[1];
                int flyLenght = int.Parse(elements[2]);

                if (ladyBugIndex < 0 || ladyBugIndex > field.Length - 1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (directions == "right")
                {
                    int landIndex = ladyBugIndex + flyLenght;

                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLenght;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {

                        field[landIndex] = 1;

                    }

                }

                else if (directions == "left")
                {
                    int landIndex = ladyBugIndex - flyLenght;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLenght;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {

                        field[landIndex] = 1;

                    }

                }

            }

            Console.WriteLine(String.Join(' ', field));

        }
    }
}
