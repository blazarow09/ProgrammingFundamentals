using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLab
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }

            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}
