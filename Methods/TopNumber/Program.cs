using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                string currentNumber = i.ToString();
                bool isOdddigit = false;
                int sumOfDigits = 0;

                foreach (var curr in currentNumber)
                {
                    int parseNumvber = (int)curr;

                    if (parseNumvber % 2 == 1)
                    {
                        isOdddigit = true;
                    }

                    sumOfDigits = sumOfDigits + parseNumvber;
                }

                if (sumOfDigits % 8 == 0 && isOdddigit)
                {
                    Console.WriteLine(i);
                }
            }

            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {

        }
    }
}
