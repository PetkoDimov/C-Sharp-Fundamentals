using System;
using System.Linq;


namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split();
            int bestCounter = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int currentCounter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (currentElement == arr[j])
                    {
                        currentCounter++;
                    }

                    else
                    {
                        break;
                    }

                }

                if (currentCounter > bestCounter)
                {
                    bestCounter = currentCounter;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }

        }
    }
}
