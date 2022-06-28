using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            int number = int.Parse(input);
            int difference = number;


            for (int i = 0; i < input.Length; i++)
            {

                number = number % 10;
                difference = difference / 10;
                sum = sum + number;
                number = difference;
            }

            //OR             for (int i = 0; i < input.Length; i++)
            //{
                //int currentNumber = (int)Char.GetNumericValue(input[i]);
                //sum = sum + currentNumber;
            //}

            Console.WriteLine(sum);
        }
    }
}
