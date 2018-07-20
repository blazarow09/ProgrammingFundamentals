using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace HexadecimalMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"\b(0x)?[0-9A-F]+\b";

            MatchCollection matched = Regex.Matches(input, pattern);

            var matchedNums = matched
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", matchedNums));
        }
    }
}
