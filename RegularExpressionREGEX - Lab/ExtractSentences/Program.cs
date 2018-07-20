using System;
using System.Text.RegularExpressions;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var inputText = Console.ReadLine();

            var pattern = $"[^.!?;]*(({key}\\W)|(\\W{key}\\W))[^.!?;]*";

            var matches = Regex.Matches(inputText, pattern);
            var count = 0;
            foreach (Match match in matches)
            {
                if (count == 0)
                {
                    Console.WriteLine(match.ToString());
                }
                else
                {
                    var sentence = Convert.ToString(match);
                    Console.WriteLine(sentence.Substring(1));
                }

                count++;
            }
        }
    }
}
