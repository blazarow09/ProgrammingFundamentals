using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();
                string pattern = @"(?<name>([a-zA-Z]+\s?){1,3}) @(?<venue>([A-Za-z]+\s?){1,3}) (?<price>\d+) (?<count>\d+)";
                Regex regex = new Regex(pattern);

            string input = Console.ReadLine(); ;
                   
            while (input != "End")
            {
                if (!regex.IsMatch(input))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    Match match = regex.Match(input);

                    string singer = match.Groups["name"].Value;
                    string venue = match.Groups["venue"].Value;
                    int pricePerTicket = int.Parse(match.Groups["price"].Value);
                    int countTickets = int.Parse(match.Groups["count"].Value);

                    if (!venues.ContainsKey(venue))
                    {
                        venues[venue] = new Dictionary<string, int>();
                    }

                    if (!venues[venue].ContainsKey(singer))
                    {
                        venues[venue][singer] = 0;
                    }

                    venues[venue][singer] += pricePerTicket * countTickets;

                    input = Console.ReadLine();
                }
            }

            foreach (var outerKvp in venues)
            {
                Console.WriteLine(outerKvp.Key);

                var artistVenue = outerKvp.Value;

                foreach (var innerKvp in artistVenue.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {innerKvp.Key} -> {innerKvp.Value}");
                }
            }
        }
    }
}



