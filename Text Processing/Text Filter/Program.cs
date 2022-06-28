using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] filteredWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in filteredWords)
            {

                string replace = new string('*', word.Length);

                text = text.Replace(word, replace);

            }

            Console.WriteLine(text);

        }
    }
}
