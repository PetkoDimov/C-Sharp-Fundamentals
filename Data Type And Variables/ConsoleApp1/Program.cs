using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a >= 'a' && a <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }

        }
    }
}
