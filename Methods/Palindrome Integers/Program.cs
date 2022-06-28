using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "END")
            {
                int currentNumber = int.Parse(input);
                string result = IsPalindrome(currentNumber).ToString()
                    .ToLower();

                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(int input)
        {
            if (input < 0)
            {
                return false;
            }
                int div = 1;

                while (input / div >= 10)
                {
                    div *= 10;
                }

                while (input != 0)
                {
                    int l = input / div;
                    int r = input % 10;

                    if (l != r)
                    {
                        return false;

                    }

                input = (input % div) / 10;
                div /= 100;
                }

            return true;
        }
    }
}
