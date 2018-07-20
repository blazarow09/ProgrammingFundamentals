using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var upSurface = Console.ReadLine();
            var upMantle = Console.ReadLine();
            var core = Console.ReadLine();
            var bottomMantle = Console.ReadLine();
            var bottomSurface = Console.ReadLine();

            string surfacePatt = @"^([\D\W]+)";
            bool surfaceUp = Regex.IsMatch(upSurface, surfacePatt);
            bool surfaceDown = Regex.IsMatch(bottomSurface, surfacePatt);

            string mantlePatt = @"([\d+_])";
            bool mantleUp = Regex.IsMatch(upMantle, mantlePatt);
            bool mantleDown = Regex.IsMatch(bottomMantle, mantlePatt);

            string middlePatt = @"(^[\D\W]+)([\d_])+(?<core>[a-zA-Zа-яА-Я]+)([\d_]+)([\D\W])";
            bool coreMatch = Regex.IsMatch(core, middlePatt);

            if (surfaceUp && mantleUp && coreMatch && surfaceDown && mantleDown)
            {
                string corePat2 = @"^[\D\W]+([\d_])+(?<core>[a-zA-ZА-Яа-я]+)";
                var coreMatches = Regex.Matches(core, corePat2);

                Match coreMatch2 = Regex.Match(core, corePat2);

                Console.WriteLine("Valid");
                Console.WriteLine(coreMatch2.Groups["core"].Length);
            }
            else
            {
                Console.WriteLine("Ivalid");
            }
        }
    }
}
