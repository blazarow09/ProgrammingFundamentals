using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToList();

            var newList = new List<string>();
            while (true)
            {
                string word = "";

                var command = Console.ReadLine();
                var tokens = command
                    .Split()
                    .ToList();

                if (tokens[0] == "3:1") break;

                if (tokens[0] == "merge")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;

                        for (int i = 0; i < endIndex; i++)
                        {
                             word = input[i] + input[i + 1];
                            newList.Add(word);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < endIndex; i++)
                        {
                            word += input[i] + input[i + 1];
                        }
                            newList.Add(word);
                    }
                }
            }
        }
    }
}
