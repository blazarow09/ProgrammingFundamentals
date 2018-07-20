using System;
using System.Collections.Generic;
using System.Linq;

namespace ArayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine().Split().ToList();


            string command = line[0];
            int index = int.Parse(line[1]);


            while (!(command == "print"))
            {
                var end = numbers.Count;
                switch (command)
                {
                    case "add":
                        int element = int.Parse(line[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        for (int i = line.Count - 1; i >= 2; i--)
                        {
                            numbers.Insert(index, (int.Parse)(line[i]));
                        }
                        break;
                    case "contains":
                        
                        if ((numbers.IndexOf(index)))
                        {

                        }
                        Console.WriteLine(numbers.IndexOf(index));
                        break;
                    case "remove":
                        numbers.RemoveAt(index);
                        break;
                    case "shift":
                        numbers = ShiftNumbers(numbers, index);
                        break;
                    case "sumPairs":
                        SumPairs(ref numbers, ref end);
                        break;
                    default:
                        Console.WriteLine();
                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        static void SumPairs(ref List<int> numbers, ref int end)
        {
            List<int> results = new List<int>();
            if (numbers.Count % 2 != 0)
                end = numbers.Count - 1;

            for (int i = 0; i < end; i += 2)
                results.Add(numbers[i] + numbers[i + 1]);
            if (numbers.Count % 2 != 0)
                results.Add(numbers.Last());
            numbers = results;
        }

        static List<int> ShiftNumbers(List<int> numbers, int index)
        {
            var result = numbers.Skip(index).ToList();
            for (int i = 0; i < index % numbers.Count; i++)
                result.Add(numbers[i]);
            numbers = result;
            return numbers;
        }
    }
}
