using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            double dayOfPlunder = double.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double Plunder = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= dayOfPlunder; i++)
            {
                sum = sum + dailyPlunder;
                if (i % 3 == 0)
                {
                    sum = sum + (dailyPlunder / 2);
                }
                if (i % 5 == 0)
                {
                    sum = sum - (sum * 0.3);
                }
            }

            double difference = sum / Plunder;
            difference = difference * 100;

            if (sum >= Plunder)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {difference:f2}% of the plunder.");
            }

        }
    }
}
