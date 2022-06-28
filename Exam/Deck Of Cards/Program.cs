using System;
using System.Collections.Generic;
using System.Linq;

namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> deck = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int input = int.Parse(Console.ReadLine());
            string command = string.Empty;

            for (int i = 0; i < input; i++)
            {
                command = Console.ReadLine();
                string[] arrayOfCommand = command.Split(", ").ToArray();
                string cmdArgs = arrayOfCommand[0];
                string nameOfCard = arrayOfCommand[1];

                if (cmdArgs == "Add")
                {
                    if (!deck.Contains(nameOfCard))
                    {
                        deck.Add(nameOfCard);
                        Console.WriteLine("Card successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }

                }
                else if (cmdArgs == "Remove")
                {
                    if (deck.Contains(nameOfCard))
                    {
                        deck.Remove(nameOfCard);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }

                else if (cmdArgs == "Remove At")
                {
                    int index = int.Parse(arrayOfCommand[1]);

                    if (index >= 0 && index < deck.Count)
                    {
                        deck.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (cmdArgs == "Insert")
                {
                    int index = int.Parse(arrayOfCommand[1]);
                    nameOfCard = arrayOfCommand[2];

                    if (index >= 0 && index < deck.Count)
                    {
                        if (deck.Contains(nameOfCard))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {


                            deck.Insert(index, nameOfCard);
                            Console.WriteLine("Card successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }


            }

            Console.WriteLine(string.Join(", ", deck));

        }
    }
}
