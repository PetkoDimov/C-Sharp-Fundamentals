﻿using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");

            foreach (string element in arr2)
            {

                for (int i = 0; i < arr1.Length; i++)
                {

                    if (element == arr1[i])
                    {
                        Console.Write(element + " ");
                        break;
                    }

                }

            }

        }
    }
}
