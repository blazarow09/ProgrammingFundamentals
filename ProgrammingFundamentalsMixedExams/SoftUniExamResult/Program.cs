using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var examResults = new Dictionary<string, int>();
            var languagesCount = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                var tokens = input
                    .Split("-")
                    .ToList();

                if (tokens.Count > 2)
                {
                    var name = tokens[0];
                    var language = tokens[1];
                    var result = int.Parse(tokens[2]);

                    if (!languagesCount.ContainsKey(language))
                    {
                        languagesCount.Add(language, 1);
                    }
                    else
                    {
                        languagesCount[language]++;
                    }


                    if (!examResults.ContainsKey(name))
                    {
                        examResults.Add(name, result);
                    }
                    else
                    {
                        var evaluation = examResults[name];
                        if (evaluation < result)
                        {
                            examResults[name] = result;
                        }
                    }
                }
                else
                {
                    var name = tokens[0];
                    examResults.Remove(name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var result in examResults.OrderByDescending(x =>x.Value).ThenBy(x => x.Key)) 
            {
                Console.WriteLine($"{result.Key} | {result.Value}");
            }
            
            Console.WriteLine("Submissions:");
            foreach (var submission in languagesCount.OrderByDescending(x => x.Value).ThenBy(x =>x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
