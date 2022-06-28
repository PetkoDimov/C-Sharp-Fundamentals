using System;

namespace Summ_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfOdds = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= NumberOfOdds; i++)
            {
                Console.WriteLine(2*i-1);
                sum = sum + 2 * i - 1;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
