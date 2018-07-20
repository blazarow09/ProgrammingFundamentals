using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var globalSet = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                if (input.Contains("->"))
                {
                    var tokens = input
                        .Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var dataKey = tokens[0];
                    var dataSize = long.Parse(tokens[1]);
                    var dataSet = tokens[2];

                    if (!globalSet.ContainsKey(dataSet))
                    {
                        globalSet[dataSet] = new Dictionary<string, long>();
                        globalSet[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        globalSet[dataSet].Add(dataKey, dataSize);

                    }
                }
                else
                {
                    var set = input;

                    if (!globalSet.ContainsKey(set))
                    {
                        globalSet[set] = new Dictionary<string, long>();
                    }
                }

                input = Console.ReadLine();
            }

            KeyValuePair<string, Dictionary<string, long>> result = globalSet
                                .OrderByDescending(ds => ds.Value.Sum(d => d.Value))
                                .First();
                
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Values.Sum()}");

            foreach (var user in result.Value)
            {
                Console.WriteLine($"$.{user.Key}");
            }

            

        }
    }
}
