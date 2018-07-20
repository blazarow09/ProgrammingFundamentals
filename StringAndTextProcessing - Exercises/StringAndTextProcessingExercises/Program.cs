using System;
using System.Collections.Generic;
using System.Linq;

namespace StringAndTextProcessingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsForBan = Console.ReadLine().Split(", ");

            var input = Console.ReadLine();


            foreach (var word in wordsForBan)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
