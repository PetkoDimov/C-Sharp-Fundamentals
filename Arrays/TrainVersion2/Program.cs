using System;

namespace TrainVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i]; // ili bez tazi operaciq
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum); // i tuk e wagons.Sum()

        }
    }
}
