using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            foreach (char ch in input)
            {
                var currentChar = ch + 3;
                Console.Write((char)currentChar);
            }

        }
    }
}
