using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            decimal result = num * (decimal)1.31;

            Console.WriteLine($"{result:F3}");
        }
    }
}
