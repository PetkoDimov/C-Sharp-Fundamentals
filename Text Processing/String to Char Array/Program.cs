using System;

namespace String_to_Char_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "Hello, C#";

            Test(a.ToCharArray());

        }


        private static void Test(char[] arr)

        {

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
