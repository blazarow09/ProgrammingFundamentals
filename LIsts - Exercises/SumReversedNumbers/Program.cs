using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> numbers = Console.ReadLine()
                .Split()
                .ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                string sada = new string(numbers[i].Reverse().ToArray());
                //string num = numbers[i];
                //char[] numArray = num.ToCharArray();
                //char[] reversedNumArray = numArray.Reverse().ToArray();
                //string result = string.Empty; 
                //for (int j = 0; j < reversedNumArray.Length; j++)
                //{
                //    result += reversedNumArray[j];
                //}
                sum += int.Parse(sada);
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
