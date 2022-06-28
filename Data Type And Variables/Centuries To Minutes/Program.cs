using System;

namespace Centuries_To_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int days = (int)(centuries * 100 * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {centuries*100} years = {(int)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
