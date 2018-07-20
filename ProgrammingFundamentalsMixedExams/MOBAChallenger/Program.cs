using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var statistic = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Season end")
            {
                var tokens = input
                    .Split()
                    .ToList();

                var player = tokens[0];
                var position = tokens[2];
                var skill = 0;
                try
                {
                    skill = int.Parse(tokens[4]);
                }
                catch (Exception)
                {

                }

                if (input == $"{player} -> {position} -> {skill}")
                {
                    if (statistic.ContainsKey(player) == false)
                    {
                        statistic[player] = new Dictionary<string, int>();
                    }

                    if (statistic[player].ContainsKey(position) == false)
                    {
                        statistic[player][position] = 0;
                    }

                    foreach (var sk in statistic[player].Values)
                    {
                        if (sk >= skill)
                        {
                            statistic[player][position] = skill;
                            break;
                        }
                        else
                        {
                            statistic[player][position] = skill;
                            break;
                        }
                    }
                }

                var playerOne = tokens[0];
                var playerTwo = tokens[2];

                if (input == $"{playerOne} vs {playerTwo}")
                {
                    if (statistic.ContainsKey(playerOne) && statistic.ContainsKey(playerTwo))
                    {
                        var playerToRemove = "";
                        foreach (var pos in statistic[playerOne].Keys)
                        {
                            if (statistic[playerTwo].ContainsKey(pos))
                            {
                                var toFind = pos;

                                var plOne = statistic[playerOne][toFind];
                                var plTwo = statistic[playerTwo][toFind];

                                if (plOne >= plTwo)
                                {
                                    playerToRemove = playerTwo;
                                }
                                else
                                {
                                    playerToRemove = playerOne;
                                }
                            }
                        }
                        statistic.Remove(playerToRemove);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var outerKvp in statistic.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                var sumSkill = outerKvp.Value.Values.Sum();
                Console.WriteLine($"{outerKvp.Key}: {sumSkill} skill");

                var innerKvp = outerKvp.Value;

                foreach (var pos in innerKvp.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }
    }
}
