using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

                int number = 0;
            Dictionary<string, int> goods = new Dictionary<string, int>();

            while (resource != "stop")
            {
                number = int.Parse(Console.ReadLine());

                if (goods.ContainsKey(resource))
                {
                    goods[resource] += number;
                }
                else
                {
                    goods.Add(resource, number);
                }

                resource = Console.ReadLine();
            }
            foreach (var item in goods)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
