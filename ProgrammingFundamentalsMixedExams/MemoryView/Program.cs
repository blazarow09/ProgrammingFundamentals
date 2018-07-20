using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = "";
            var words = new List<string>();

            while (input != "Visual Studio crash")
            {
                result += input + " ";

                input = Console.ReadLine();
            }

            string[] token = result.Split(" ", 
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < token.Length; i++)
            {
                if (token[i] == "32656" && token[i + 1] == "19759" && token[i + 2] == "32763" && token[i + 3] == "0" && token[i + 5] == "0")
                {
                    string word = "";

                    int wordLength = int.Parse(token[i + 4]);

                    for (int j = i + 6; j < i + 6 + wordLength; j++)
                    {
                        word += (char)(int.Parse(token[j]));
                    }

                    words.Add(word);

                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
