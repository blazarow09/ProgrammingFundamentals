using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var statistic = new Dictionary<string, Dictionary<string, int>>();

            while (input != "report")
            {
                var tokens = input
                    .Split("|")
                    .ToList();

                var city = tokens[0];
                var country = tokens[1];
                var population = tokens[2];

                if (!statistic.ContainsKey(country))
                {
                    statistic[country] = new Dictionary<string, int>();
                }

                if (!statistic[country].ContainsKey(city))
                {
                    statistic[country][city] = 0;
                }

                statistic[country][city] += int.Parse(population);

                input = Console.ReadLine();
            }
            
            foreach (var outerKvp in statistic)
            {
                var town = outerKvp.Value;
                int totalPopulationInCountry = town.Values.Sum();
                
                Console.WriteLine($"{outerKvp.Key} (total population: {totalPopulationInCountry})");

                foreach (var innerKvp in town.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{innerKvp.Key}: {innerKvp.Value}");
                }
            }
        }
    }
}
