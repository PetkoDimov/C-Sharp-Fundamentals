using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {

            int energy = int.Parse(Console.ReadLine());
            int battles = 0;
            int wins = 0;
            bool isWon = true;

            string input = Console.ReadLine();

            while (input?.ToUpper() != "END OF BATTLE")
            {
                battles++;
                int distance = int.Parse(input);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWon = false;
                    break;
                }
                wins++;
                energy = energy - distance;

                if (battles % 3 == 0)
                {
                    energy = energy + wins;
                }

                input = Console.ReadLine();
            }

            if (isWon)
            {


                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");

            }
        }
    }
}
