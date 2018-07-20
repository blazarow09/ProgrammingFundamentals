using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var commands = "";

            while (true)
            {
                commands = Console.ReadLine();
                if (commands == "end") break;

                var tokens = commands
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = tokens[0];

                if (command == "reverse")
                {

                    int start = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);
                    if (start > arrNumbers.Count && count > arrNumbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        arrNumbers.Reverse(start, count);
                    }

                }

                if (command == "sort")
                {
                    int start = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);
                    try
                    {
                        arrNumbers.Sort(start, count, null);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    
                    
                }

                int length = arrNumbers.Count;
                if (command == "rollLeft")
                {
                    try
                    {
                        int count = int.Parse(tokens[1]);
                        for (int i = 0; i < count; i++)
                        {
                            int num = arrNumbers[0];
                            arrNumbers.RemoveAt(0);
                            arrNumbers.Insert(length, num);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    
                }

                if (command == "rollRight")
                {
                     int count = int.Parse(tokens[1]);


                    try
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int num = arrNumbers[length - 1];
                            arrNumbers.RemoveAt(length - 1);
                            arrNumbers.Insert(0, num);

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

            }
            Console.WriteLine("[" + string.Join(", ", arrNumbers) + "]");
        }
    }
}
