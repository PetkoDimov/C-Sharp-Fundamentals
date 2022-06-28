using System;
using System.Numerics;
namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger biggestValue = 0;
            double biggestSnowballSnow = 0;
            double biggestSnowballTime = 0;
            double biggestSnowballQuality = 0;


            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowDivided = snowballSnow / snowballTime;

                BigInteger snowballValue = BigInteger.Pow(snowDivided, snowballQuality);

                if (snowballValue > biggestValue)
                {
                    biggestValue = snowballValue;
                    biggestSnowballSnow = snowballSnow;
                    biggestSnowballTime = snowballTime;
                    biggestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {biggestValue} ({biggestSnowballQuality})");
        }

    }
}
