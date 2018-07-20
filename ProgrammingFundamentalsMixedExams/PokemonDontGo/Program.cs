using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var sum = new List<int>();
            var oldInd = 99999999999999;
            var num = 0;

            while (numbers.Count != 0)
            {
                var index = Console.ReadLine();
                var ind = int.Parse(index);

                int last = numbers.Count - 1;

                if (ind < 0)
                {
                    int numb = numbers[last];
                    sum.Add(numbers[0]);
                    numbers.RemoveAt(0);
                    numbers.Remove(numb);
                    numbers.Insert(0, numb);
                }
                else if (ind > oldInd)
                {
                    sum.Add(numbers[last]);
                    num = numbers[last];
                    numbers.RemoveAt(last);
                    int first = numbers[0];
                    numbers.Insert(last, first);
                }
                else
                {
                    num = numbers[ind];
                    sum.Add(num);
                    numbers.RemoveAt(ind);
                }

                oldInd = ind;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= num)
                    {
                        numbers[i] += num;
                    }
                    else
                    {
                        numbers[i] -= num;
                    }
                }
            }
            Console.WriteLine(string.Join("", sum.Sum()));
        }
    }
}
