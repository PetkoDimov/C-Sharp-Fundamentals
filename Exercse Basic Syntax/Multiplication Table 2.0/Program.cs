using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startMultiplier = int.Parse(Console.ReadLine());
            int sum = 0;

            if (startMultiplier > 10)
            {
                Console.WriteLine($"{number} X {startMultiplier} = {number * startMultiplier}");
            }
            else
            {

                for (int i = startMultiplier; i <= 10; i++)
                {
                    sum = i * number;
                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
        }
    }
}

