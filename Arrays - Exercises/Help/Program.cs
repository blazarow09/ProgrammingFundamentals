using System;
using System.Linq;

namespace _6._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int digit = 0;
            int longest = 0;
            int max = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {



                if (arr[i] == arr[i + 1])
                {
                    longest++;
                    if (max < longest)
                    {
                        digit = i - longest;
                        max = longest;
                    }

                    else
                    {
                        longest = 0;
                    }

                }
            }
            for (int i = digit + 1; i < digit + max + 1; i++)
            {
                Console.Write(digit + " ");
            }
        }
    }
}