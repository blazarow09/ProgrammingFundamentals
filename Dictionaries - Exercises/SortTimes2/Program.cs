using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTimes2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> times = new SortedDictionary<string, string>();

            var line = Console.ReadLine().Split().ToList();

            foreach (var time in line)
            {
                if (!times.ContainsKey(time))
                {
                    times.Add(time, "Time");
                }
            }

            Console.WriteLine(string.Join(", ", times.Keys));
        }
    }
}
