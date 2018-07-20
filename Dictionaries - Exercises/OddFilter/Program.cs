using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var oddNums = new List<int>();
            var others = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    oddNums.Add(num);
                }
                else
                {
                    others.Add(num);
                }
            }

            double avg = others.Average();

            var numsToPrint = new List<int>();

            foreach (var num in others)
            {
                if (num > avg)
                {
                    numsToPrint.Add(num + 1);
                }
                else
                {
                    numsToPrint.Add(num - 1);
                }
            }

            Console.WriteLine(string.Join(" ", numsToPrint));
        }
    }
}