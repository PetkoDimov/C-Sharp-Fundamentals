using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;
            string biggestKeg = string.Empty;
            double biggestVolume = 0;


            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigh = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * heigh;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = name;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
