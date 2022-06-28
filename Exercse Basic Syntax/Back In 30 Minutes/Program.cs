using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());

            double minutes = double.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60 )
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }

            if (hour == 24)
            {
                hour = 0;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
