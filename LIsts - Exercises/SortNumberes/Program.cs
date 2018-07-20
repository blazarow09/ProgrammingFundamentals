using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumberes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersInput = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            numbersInput.Sort();

            Console.WriteLine(string.Join(" <= ", numbersInput));

        }
    }
}
