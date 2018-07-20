using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = Console.ReadLine();

            var pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            var matches = Regex.Matches(emails, pattern);

            foreach (Match email in matches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
