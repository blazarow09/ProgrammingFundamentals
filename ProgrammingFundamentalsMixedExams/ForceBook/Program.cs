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

            var book = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {

                    var tokens = input
                        .Split(" | ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var side = tokens[0];
                    var player = tokens[1];

                    if (!book.ContainsKey(side))
                    {
                        book[side] = new List<string>();
                        book[side].Add(player);
                    }
                    else
                    {
                        if (!book[side].Contains(player))
                        {
                            book[side].Add(player);
                        }
                    }
                }
                else
                {
                    var tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                    var side = tokens[1];
                    var player = tokens[0];

                    var ifSucces = true;

                    foreach (var sides in book)
                    {
                        if (sides.Value.Contains(player))
                        {
                            ifSucces = false;
                            sides.Value.Remove(player);
                            book[side].Add(player);
                            Console.WriteLine($"{player} joins the {side} side!");
                            break;
                        }
                    }

                    if (ifSucces == true)
                    {
                        foreach (var sides in book)
                        {
                            if (!sides.Value.Contains(player))
                            {
                                book[side].Add(player);
                                Console.WriteLine($"{player} joins the {side} side!");
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var outerDict in book.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                //if (outerDict.Value.Count >= 1)
                //{
                var totalMembers = outerDict.Value.Count;
                Console.WriteLine($"Side: {outerDict.Key}, Members: {totalMembers}");

                foreach (var member in outerDict.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {member}");
                }
                //}
            }
        }
    }
}
