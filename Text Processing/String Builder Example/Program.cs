using System;
using System.Text;
using System.Linq;


namespace String_Builder_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello Peter, how are you?");

            Console.WriteLine(sb[5]);

            sb.Insert(11, " Ivanov");

            Console.WriteLine(sb);

            sb.Replace("Peter", "Mitko");

            Console.WriteLine(sb);
        }
    }
}
