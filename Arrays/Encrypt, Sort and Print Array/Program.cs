using System;
using System.Linq;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            char[] arr = name.ToCharArray();
            int[] final = new int[start];
            int result = 0;
            int calculator = 0;

            for (int i = 0; i < start; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'a' || arr[j] == 'A' || arr[j] == 'e' || arr[j] == 'E' || arr[j] == 'o' || arr[j] == 'O' || arr[j] == 'u' || arr[j] == 'U' || arr[j] == 'i' || arr[j] == 'I')
                    {
                        calculator = (int)arr[j] * name.Length; 

                        result = result + calculator;
                    }
                    else
                    {

                        result = result + (int)arr[j] / name.Length;
                    }
                }
                final[i] = result;
                result = 0;
                if (i == start - 1)
                {
                    break;
                }
                else 
                {
                    name = Console.ReadLine();
                    arr = name.ToCharArray();

                }
            }

            Array.Sort(final);
            foreach (int item in final)
            {
                Console.WriteLine(item);
            }
            


        }
    }
}
