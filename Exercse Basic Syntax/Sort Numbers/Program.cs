using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thurdNumber)
            {
                Console.WriteLine(firstNumber);
                if (secondNumber > thurdNumber)
                {
                    Console.WriteLine(secondNumber);
                    Console.WriteLine(thurdNumber);
                }
                else
                {
                    Console.WriteLine(thurdNumber);
                    Console.WriteLine(secondNumber);
                }

            }
            else if (secondNumber > firstNumber && secondNumber > thurdNumber)
            {
                Console.WriteLine(secondNumber);
                if (firstNumber > thurdNumber)
                {
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(thurdNumber);
                }
                else
                {
                    Console.WriteLine(thurdNumber);
                    Console.WriteLine(firstNumber);
                }
            }
            else if (thurdNumber > firstNumber && thurdNumber > secondNumber)
            {
                Console.WriteLine(thurdNumber);
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                    Console.WriteLine(firstNumber);
                }
            }
        }
    }
}
