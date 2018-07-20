using System;
using System.Collections.Generic;
using System.Linq;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var splited = input.Split("., ?!.".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToList();
            var palindromes = new List<string>();

            foreach (var word in splited)
            {
                string rev = new string(word.Reverse().ToArray());
               
                if (rev == word)
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",palindromes.Distinct().OrderBy(x=>x)));
        }
    }
}
