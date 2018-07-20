using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();

            string pattern = @"((\+359-2-\d{3}-\d{4})|(\+359 2 \d{3} \d{4}))";

            var matches = Regex.Matches(numbers, pattern);

            var matchedPhones = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
