using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNativesAndReverse
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> removed = new List<int>();
            List<int> added = new List<int>();

            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    removed.Add(num);
                }
                else
                {
                    added.Add(num);
                }
            }

            if (added.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                added.Reverse();
                Console.WriteLine(string.Join(" ", added));
            }
        }
    }
}
