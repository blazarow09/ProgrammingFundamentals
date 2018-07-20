using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            var input = Console.ReadLine();

            string pattern = @"(?<town>[A-Z]{2})(?<temp>[0-9]{1,2}.[0-9]{1,2})(?<type>[a-zA-Z]+)\|";

            var dict = new SortedDictionary<string, KeyValuePair<float, string>>();

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var city = match.Groups["town"].Value;
                    var temp = match.Groups["temp"].Value;
                    var type = match.Groups["type"].Value;

                    if (!dict.ContainsKey(city))
                    {
                        dict[city] = new KeyValuePair<float, string>(float.Parse(temp), type);
                    }
                    else
                    {
                        dict[city] = new KeyValuePair<float, string>(float.Parse(temp), type);

                    }

                }
                input = Console.ReadLine();
            }
            var sortedDict = dict.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} => {item.Value.Key:f2} => {item.Value.Value}");
            }
        }
    }
}
