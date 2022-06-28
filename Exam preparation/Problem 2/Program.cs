using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            string pattern = @">([1-9]{3})\|+([a-z]{3})\|+([A-Z]{3})\|+([^\w<>]{3})<";

            for (int i = 0; i < start; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string first = string.Empty;

                    first = match.Groups[1].Value;
                    string second = match.Groups[2].Value;
                    string third = match.Groups[3].Value;
                    string forth = match.Groups[4].Value;
                    StringBuilder sb = new StringBuilder();
                    sb = sb.Append(first);
                    sb = sb.Append(second);
                    sb = sb.Append(third);
                    sb = sb.Append(forth);

                    Console.WriteLine($"Password: {sb}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }

            }

        }
    }
}
// ##>123|yes|YES|!!!<##