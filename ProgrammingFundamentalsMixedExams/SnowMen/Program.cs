using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowMen
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = 0;
            var atacker = 0;
            var diff = 0;

            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            var lost = new List<int>();

            var length = sequence.Count;
            while (sequence.Count != 1)
            {
                for (int index = 0; index < sequence.Count; index++)
                {
                    if (Math.Abs(lost.Count - sequence.Count) == 1) continue;

                    if (lost.Contains(index)) continue;

                    atacker = index;
                    target = ValidNum(sequence[atacker], sequence.Count);

                    diff = Math.Abs(atacker - target);

                    if (diff == 0)
                    {
                        Console.WriteLine($"{target} performed harakiri");
                        lost.Add(atacker);
                        lost = lost.Distinct().ToList();
                    }

                    if (diff != 0 && diff % 2 == 0)
                    {
                        Console.WriteLine($"{atacker} x {target} -> {atacker} wins");
                        lost.Add(target);
                        lost = lost.Distinct().ToList();
                    }

                    if (diff % 2 == 1)
                    {
                        Console.WriteLine($"{atacker} x {target} -> {target} wins");
                        lost.Add(atacker);
                        lost = lost.Distinct().ToList();
                    }
                }
                foreach (var index in lost.OrderByDescending(x => x).Distinct())
                {
                    sequence.RemoveAt(index);
                }
                lost.Clear();
            }
        }
        static int ValidNum(int i, int length)
        {
            if (i >= length)
            {
                i = i % length;
            }
            return i;
        }
    }
}
