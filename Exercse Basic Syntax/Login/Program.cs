﻿using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int counter = 0;

            for (int i = username.Length -1; i >= 0; i--)
            {
                password += username[i];
            }

            while (true)
            {
                string currentUser = Console.ReadLine();

                if (currentUser != password)
                {
                    counter++;

                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }

                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
