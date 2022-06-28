using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double ballance = double.Parse(Console.ReadLine());
            double sum = 0;
            string input = Console.ReadLine();
            double gamePrice = 0;
            double result = ballance;
            bool isFound = false;
            string output = string.Empty;

            while (input != "Game Time")
            {

                if (input == "OutFall 4")
                {
                    gamePrice = 39.99;
                    isFound = true;
                }
                else if (input == "CS: OG")
                {
                    gamePrice = 15.99;
                    isFound = true;
                }
                
                else if (input == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    isFound = true;
                }                
                
                else if (input == "Honored 2")
                {
                    gamePrice = 59.99;
                    isFound = true;
                }                
                
                else if (input == "RoverWatch")
                {
                    gamePrice = 29.99;
                    isFound = true;
                }
               
                else if (input == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    isFound = true;
                }

                else
                {
                    Console.WriteLine("Not Found");
                }

                if (gamePrice > ballance || result < gamePrice)
                {
                    output = "Too Expensive";
                    Console.WriteLine(output);

                }

                if (isFound && output != "Too Expensive")
                {


                    sum += gamePrice;

                    result = result - gamePrice;

                    Console.WriteLine($"Bought {input}");

                }

                if (result == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                output = string.Empty;
                input = Console.ReadLine();
            }
            if (input == "Game Time")
            {


                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${result:f2} ");

            }
        }
    }
}
