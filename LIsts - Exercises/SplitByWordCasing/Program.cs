using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            bool isVaild = true;

            foreach (char symbol in input)
            {
                if ('A' < symbol || symbol > 'Z')
                {
                    return false;
                }

            }
        }

        //static bool UpperCase(string input)
        //{
        //    foreach (char symbol in input)
        //    {
        //        if ('A' < symbol || symbol > 'Z')
        //        {
        //            return false;
        //        }
               
        //    }
        //        return true;
        //}

        static bool LowerCase(string input)
        {
            foreach (char symbol in input)
            {
                if ('a' < symbol || symbol > 'z')
                {
                    return false;
                }

            }
                return true;
        }

    }
}
