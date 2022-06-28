using System;

namespace Fundamentals_FinalExam_13122020
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Case":
                        if (tokens[1] == "lower")
                        {
                            userName = userName.ToLower();
                        }
                        else if (tokens[1] == "upper")
                        {
                            userName = userName.ToUpper();
                        }
                        Console.WriteLine(userName);
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        if (!((startIndex < 0 || startIndex > userName.Length) || (endIndex < 0 || endIndex > userName.Length)))
                        {
                            string subUserName = userName.Substring(startIndex, endIndex - startIndex + 1);
                            subUserName = Reverse(subUserName);
                            Console.WriteLine(subUserName);
                        }

                        break;

                    case "Cut":
                        string toCut = tokens[1];
                        int index = userName.IndexOf(toCut);
                        if (index != -1)
                        {
                            userName = userName.Remove(index, toCut.Length);
                            Console.WriteLine(userName);
                        }
                        else
                        {
                            Console.WriteLine($"The word {userName} doesn't contain {toCut}.");
                        }
                        break;

                    case "Replace":
                        char toReplace = char.Parse(tokens[1]);
                        userName = userName.Replace(toReplace, '*');
                        Console.WriteLine(userName);
                        break;

                    case "Check":
                        char toCheck = char.Parse(tokens[1]);
                        if (userName.Contains(toCheck))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {toCheck}.");
                        }
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}