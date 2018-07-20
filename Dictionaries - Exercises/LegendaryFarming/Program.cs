using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, string>();
            var junkMaterials = new Dictionary<string, string>();

            string input = Console.ReadLine();

            var tokens = input.Split().ToList();

            foreach (var token in tokens)
            {
                if (token == "fragments")
                {
                    keyMaterials.Add(token, token+1);
                }
            }
            Console.WriteLine();
        }
    }
}
