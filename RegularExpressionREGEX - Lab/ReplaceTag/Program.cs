﻿using System;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); ;
            string replaced = "";
            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                replaced = Regex.Replace(text, pattern, replace);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
