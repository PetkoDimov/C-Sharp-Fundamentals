using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{arr[j]} ");
                sum = sum + arr[j];
            }
            Console.WriteLine("");
            Console.WriteLine($"{sum}");
        }
    }
}
