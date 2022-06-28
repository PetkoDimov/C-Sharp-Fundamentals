using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGrade(grade);
        }

        static void PrintGrade(double ocenka)
        {

            if (ocenka >= 2.00 && ocenka <= 2.99)
            {
                Console.WriteLine("Fail");
            }

            else if (ocenka >= 3.00 && ocenka <= 3.49)
            {
                Console.WriteLine("Poor");
            }

            else if (ocenka >= 3.50 && ocenka <= 4.49) 
            {
                Console.WriteLine("Good");
            }

            else if (ocenka >= 4.50 && ocenka <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (ocenka >= 5.50 && ocenka <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
