using System;
using System.Collections.Generic;
using System.Linq;

namespace LIstsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int maxNum = 0;
            int max = 0;
            for (int i = 0; i  < numbers.Count - 1; i ++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > max)
                {
                    max = count;
                    maxNum = numbers[i];
                }
            }


            if (count > max)
            {
                max = count;
                maxNum = max;
            }

            for (int i = 0; i < maxNum; i++)
            {
                Console.WriteLine(string.Join(" ", maxNum));
            }
            Console.WriteLine();
        }
    }
}
