using System;
using System.Collections.Generic;
using System.Linq;

namespace Crafting
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> weapon = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string weaponPart = string.Empty;
            string input = Console.ReadLine();

            while (input != "Done")
            {

                string[] command = input.Split(' ');
                string cmdArgs = command[1];

                if (cmdArgs == "Left")
                {
                    int index = int.Parse(command[2]);

                    if (index < 0 || index > weapon.Count - 1)
                    {


                    }

                    else
                    {


                        weaponPart = weapon[index];
                        if (index - 1 < 0)
                        {

                        }
                        else
                        {

                            weapon.RemoveAt(index);

                            weapon.Insert(index - 1, weaponPart);

                        }
                    }
                }
                else if (cmdArgs == "Right")
                {
                    int index = int.Parse(command[2]);

                    if (index < 0 || index > weapon.Count - 1)
                    {

                    }
                    else
                    {

                        weaponPart = weapon[index];
                        if ((index+ 1) >= weapon.Count)
                        {

                        }
                        else
                        {
                            weapon.RemoveAt(index);
                            weapon.Insert(index + 1, weaponPart);

                        }
                    }
                }
                else if (cmdArgs == "Even")
                {

                    for (int i = 0; i <= weapon.Count - 1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"{weapon[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (cmdArgs == "Odd")
                {
                    for (int i = 0; i <= weapon.Count - 1; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.Write($"{weapon[i]} ");
                        }
                    }
                    Console.WriteLine();
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", weapon)}!");

        }
    }
}
