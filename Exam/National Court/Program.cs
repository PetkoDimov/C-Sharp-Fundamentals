using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPerson = int.Parse(Console.ReadLine());
            int secondPerson = int.Parse(Console.ReadLine());
            int thirdPerson = int.Parse(Console.ReadLine());
            int person = int.Parse(Console.ReadLine());
            int time = 0;

            while (person > 0)
            {
                person = person - firstPerson - secondPerson - thirdPerson;
                time++;
                if (time % 4 == 0)
                {
                    time++;
                }
            }

            Console.WriteLine($"Time needed: {time}h.");

        }
    }
}
