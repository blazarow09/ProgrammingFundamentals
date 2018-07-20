using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[i] - numbers[j] == difference || numbers[j] - numbers[i] == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
