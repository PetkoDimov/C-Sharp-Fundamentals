using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            while (people > 0 && people != 0)
            {
                people -= capacity;
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
