using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArg = command.Split();
                string firstCommand = cmdArg[0];
                int element = int.Parse(cmdArg[1]);

                if (firstCommand == "Delete")
                {
                    listOfInt.RemoveAll(x => x == element);
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);
                    listOfInt.Insert(index, element);
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", listOfInt));

        }
    }
}
