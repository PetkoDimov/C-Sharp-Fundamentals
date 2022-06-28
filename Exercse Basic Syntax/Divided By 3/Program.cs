using System;

namespace Divided_By_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 100;

            for (int i = 3; i < input; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
