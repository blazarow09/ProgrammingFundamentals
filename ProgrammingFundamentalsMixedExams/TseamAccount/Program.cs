using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tseam = Console.ReadLine()
                .Split()
                .ToList();
            var input = Console.ReadLine();

            while (input != "Play!")
            {
                var tokens = input.Split().ToList();

                var command = tokens[0];
                var game = tokens[1];

                if (command == "Install")
                {
                    if (tseam.Contains(game) == false)
                    {
                        tseam.Add(game);
                    }
                }

                if (command == "Uninstall")
                {
                    if (tseam.Contains(game))
                    {
                        tseam.Remove(game);
                    }
                }

                if (command == "Update")
                {
                    if (tseam.Contains(game))
                    {
                        tseam.Remove(game);
                        tseam.Add(game);
                    }
                }

                if (command == "Expansion")
                {
                    var toFind = game.Split("-").ToList();
                    if (tseam.Contains(toFind[0]))
                    {
                        var index = tseam.IndexOf(toFind[0]);
                        var gameToAdd = toFind[0] + ":" + toFind[1];
                        tseam.Insert(index + 1, gameToAdd);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", tseam));
        }
    }
}
