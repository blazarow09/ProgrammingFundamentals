using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> numbersTaken = new List<int>();


            numbersTaken = numbers.Take(commands[0]).ToList();
            numbersTaken.RemoveRange(0, commands[1]);

            if (numbersTaken.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
