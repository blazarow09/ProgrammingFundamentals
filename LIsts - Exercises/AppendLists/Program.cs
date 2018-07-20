using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            var result = new List<string>();

            foreach (var item in items)
            {
                List<string> nums = item.Split(" ").ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
