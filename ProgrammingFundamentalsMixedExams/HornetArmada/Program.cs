using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var armada = new Dictionary<string, Dictionary<string, long>>();
            var activity = new Dictionary<string, long>();
            
                for (int i = 0; i < n; i++)
                {
                    var input = Console.ReadLine()
                        .Split(" =->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    var lastActivity = long.Parse(input[0]);
                    var legionName = input[1];
                    var soldierType = input[2];
                    var soldierCount = long.Parse(input[3]);

                    if (!armada.ContainsKey(legionName))
                    {
                        armada[legionName] = new Dictionary<string, long>();
                        activity[legionName] = lastActivity;
                    }

                    if (!armada[legionName].ContainsKey(soldierType))
                    {
                        armada[legionName][soldierType] = 0;
                    }

                    armada[legionName][soldierType] += soldierCount;

                    if (activity[legionName] < lastActivity)
                    {
                        activity[legionName] = lastActivity;
                    }
                }

                var lastInput = Console.ReadLine().Split('\\');

                if (lastInput.Length < 2)
                {
                    var currentSoldierType = lastInput[0];

                    foreach (var legion in activity.OrderByDescending(x => x.Value))
                    {
                        if (armada[legion.Key].ContainsKey(currentSoldierType))
                        {
                            Console.WriteLine($"{legion.Value} : {legion.Key}");
                        }
                    }
                }
                else
                {
                    var currentActivity = long.Parse(lastInput[0]);
                    var currentSoldierType = lastInput[1];

                    foreach (var legion in armada
                        .Where(x => x.Value.ContainsKey(currentSoldierType))
                        .OrderByDescending(x => x.Value[currentSoldierType]))
                    {
                        if (activity[legion.Key] < currentActivity && armada[legion.Key].ContainsKey(currentSoldierType))
                        {
                            Console.WriteLine($"{legion.Key} -> {armada[legion.Key][currentSoldierType]}");
                        }
                    }
                }
            }
        }
    }



