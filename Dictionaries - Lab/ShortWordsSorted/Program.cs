using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = (".,:;()[]\"'\\/!? ").ToCharArray();

            var input = Console.ReadLine()
                .ToLower()
                .Split(arr, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
