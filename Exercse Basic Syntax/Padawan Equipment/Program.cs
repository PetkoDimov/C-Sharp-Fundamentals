using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOflightsaber = double.Parse(Console.ReadLine());
            double priceOfrobes = double.Parse(Console.ReadLine());
            double priceOfbelts = double.Parse(Console.ReadLine());
            int lightsabers = (int)(students + Math.Ceiling(students * 0.1));

            double sumOfLightsabers = lightsabers * priceOflightsaber;

            double sumOfBelts = ((students - (students / 6)) * priceOfbelts);

            double sumOfRobes = (students * priceOfrobes);
            double SUM = sumOfBelts + sumOfLightsabers + sumOfRobes;

            if (SUM <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {SUM:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {SUM - budget:f2}lv more.");
            }
        }
    }
}


