using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amountinTank = 0;

            for (int i = 0; i < n; i++)
            {
                int waterToPour = int.Parse(Console.ReadLine());
                bool isFull = waterToPour > 255;
                bool isOverflowed = amountinTank + waterToPour > 255;

                if (isFull || isOverflowed)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                        
                }

                amountinTank = amountinTank + waterToPour;
            }

            Console.WriteLine(amountinTank);
        }
    }
}
