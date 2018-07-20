using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
           
            var stack = new Dictionary<string, int>();

            var number = 0;
            while (input != "stop")
            {
                number = int.Parse(Console.ReadLine());

                if (stack.ContainsKey(input))
                {
                    stack[input] += number;
                }
                else
                {
                    stack.Add(input, number);
                }

                input = Console.ReadLine();
            }

            foreach (var item in stack) 
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
