using System;
using System.Text.RegularExpressions;


namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            string bojomonPatt = @"[\w]+-[\w]+)";
            string didimonPatt = @"([^\w-])";

            Regex didiReg = new Regex(didimonPatt);
            Regex bojoReg = new Regex(bojomonPatt);

            while (true)
            {
                var matches = Regex.Matches(didimonPatt, text);

                foreach (Match m in matches)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
