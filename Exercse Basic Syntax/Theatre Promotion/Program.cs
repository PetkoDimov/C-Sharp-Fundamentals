using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age < 0 || age >123)
            {
                Console.WriteLine("Error!");
            }

            else if (typeOfDay == "Weekday")
            {
                if (age >= 0 && age <= 18  )
                {
                    price = 12;
                }
                else if (age > 18 && age <=64)
                {
                    price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                }
                Console.WriteLine($"{price}$");

            }

            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }

                Console.WriteLine($"{price}$");

            }

            else if (typeOfDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }

                Console.WriteLine($"{price}$");

            }

        }
    }
}
