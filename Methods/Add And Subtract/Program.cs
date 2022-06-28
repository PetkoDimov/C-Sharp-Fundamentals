using System;

namespace Add_And_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber, thurdNumber);

            Console.WriteLine(sum);
        }

        private static int Sum(int firstNumber, int secondNumber, int thurdNumber)
        {
            int sumFirstAndSecont = firstNumber + secondNumber;
            return Subtract(sumFirstAndSecont, thurdNumber);
        }

        private static int Subtract(int sumFirstAndSecont, int thurdNumber)
        {
            return sumFirstAndSecont - thurdNumber;
        }
    }
}
