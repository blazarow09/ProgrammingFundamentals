using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int defDamage = 45;
            int defHealth = 250;
            int defArmor = 10;

            var typeOfDragons = new SortedDictionary<string,
                Dictionary<string,
                Dictionary<int,
                Dictionary<int, int>>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var tokens = input.Split().ToList();

                var type = tokens[0];
                var name = tokens[1];
                var damage = int.Parse(tokens[2]);
                var health = int.Parse(tokens[3]);
                var armor = int.Parse(tokens[4]);

                if (!typeOfDragons.ContainsKey(type))
                {
                    typeOfDragons[type] = new Dictionary<string, Dictionary<int, Dictionary<int, int>>>();
                }

                if (!typeOfDragons[type].ContainsKey(name))
                {
                    typeOfDragons[type][name] = new Dictionary<int, Dictionary<int, int>>();
                }

                if (!typeOfDragons[type][name].ContainsKey(damage))
                {
                    typeOfDragons[type][name][damage] = new Dictionary<int, int>();
                }

                if (!typeOfDragons[type][name][damage].ContainsKey(health))
                {
                    typeOfDragons[type][name][damage].Add(health, armor);
                }

            }
                foreach (var typpe in typeOfDragons)
                {
                    Console.WriteLine($"{typpe.Key}::({typpe.Value}//)");
                }
        }
    }
}
