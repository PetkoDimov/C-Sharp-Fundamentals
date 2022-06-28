using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> output = new Dictionary<string, int>();

            string resourses = Console.ReadLine();

            while (resourses != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!output.ContainsKey(resourses))
                {

                    output.Add(resourses, 0);

                }
                output[resourses] += quantity;

                resourses = Console.ReadLine();
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            
        }
    }
}
