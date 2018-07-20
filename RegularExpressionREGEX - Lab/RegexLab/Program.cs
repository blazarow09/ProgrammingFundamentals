using System;
using System.Text.RegularExpressions;

namespace RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matched = Regex.Matches(input, pattern);

            foreach (Match name in matched)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
