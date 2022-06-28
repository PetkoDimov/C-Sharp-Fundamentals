using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice diceD6 = new Dice();
            diceD6.Sides = 6;
            Console.WriteLine(diceD6.Roll());

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(diceD6.Roll());
            }
        }
    }
}
