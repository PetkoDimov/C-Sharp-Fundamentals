using System;
using System.Text.RegularExpressions;

namespace Fundamentals_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\|([A-Z]{4,})\|:\#([A-Z][a-z]+\s[A-Za-z]+)\#";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    int strength = match.Groups[1].Value.Length;
                    int armour = match.Groups[2].Value.Length;
                    Console.WriteLine($"{match.Groups[1].Value}, The {match.Groups[2].Value}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armour: {armour}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }

            }
        }
    }
}
