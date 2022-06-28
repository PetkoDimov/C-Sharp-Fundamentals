using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];

            array[0] = 101;
            array[1] = 102;
            array[2] = 103;
            array[3] = 104;

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
