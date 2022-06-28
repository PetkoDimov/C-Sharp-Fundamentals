using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] command = input.Split();
                string cmdArg = command[0];
                string product = command[1];


                if (cmdArg == "Urgent" && !shopingList.Contains(product))
                {


                    shopingList.Insert(0, product);

                }

                else if (cmdArg == "Unnecessary")
                {
                    shopingList.Remove(product);
                }

                else if (cmdArg == "Correct" && shopingList.Contains(product))
                {
                    string newItem = command[2];


                    int indexOfProduct = shopingList.IndexOf(product);
                    shopingList.RemoveAt(indexOfProduct);
                    shopingList.Insert(indexOfProduct, newItem);

                }

                else if (cmdArg == "Rearrange" && shopingList.Contains(product))
                {

                    shopingList.Remove(product);
                    shopingList.Add(product);

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
