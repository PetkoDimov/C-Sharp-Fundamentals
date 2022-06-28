using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfChars = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;

            for (int i = 0; i < countOfChars; i++)
            {
                char input = char.Parse(Console.ReadLine());
                number = Convert.ToInt32(input);
                sum = sum + number;

            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
