using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var matched = Regex.Matches(input, regex);

            foreach (Match num in matched)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
