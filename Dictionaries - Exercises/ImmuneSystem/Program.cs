using System;
using System.Collections.Generic;
using System.Linq;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var immuneSystem = new List<string>();

            double startHealth = double.Parse(line);
            double health = double.Parse(line);

            while (true)
            {
                var virusStrength = 0;
                double virStr = 0;
                double timeToDefeatInSec = 0;

                line = Console.ReadLine();

                if (line == "end")
                {
                    Math.Floor(health = health * 0.20 + health);
                    Console.WriteLine($"Final Health: {Math.Abs(health):f0}");
                    break;
                }

                if (!immuneSystem.Contains(line))
                {
                    UnknownVirus(line, immuneSystem, startHealth, ref health, ref virusStrength, ref virStr, ref timeToDefeatInSec);

                }
                else if (immuneSystem.Contains(line))
                {
                    IfKnowTheVirus(line, startHealth, ref health, ref virusStrength, ref virStr, ref timeToDefeatInSec);
                }
            }
        }

        static void UnknownVirus(string line, List<string> immuneSystem, double startHealth, ref double health, ref int virusStrength, ref double virStr, ref double timeToDefeatInSec)
        {
            immuneSystem.Add(line);

            foreach (var letter in line)
            {
                var virus = letter;
                virusStrength += virus;
                Math.Floor(virStr = virusStrength / 3);
                timeToDefeatInSec = virStr * line.Length;
            }

            Math.Floor(health = health * 0.20 + health);

            if (health > 0)
            {

                if (health > startHealth)
                {
                    health = startHealth;
                }

                health = Math.Floor(health - timeToDefeatInSec);

                Console.WriteLine($"Virus {line}: {virStr} => {Math.Floor(timeToDefeatInSec):f0} seconds");
                Console.WriteLine($"{line} defeated in {Math.Floor(timeToDefeatInSec / 60):f0}m {Math.Floor(timeToDefeatInSec % 60):f0}s.");
                Console.WriteLine($"Remaining health: {Math.Floor(health):f0}");
            }
            else if (health < 0)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
        }

        static void IfKnowTheVirus(string line, double startHealth, ref double health, ref int virusStrength, ref double virStr, ref double timeToDefeatInSec)
        {
            foreach (var letter in line)
            {
                var virus = letter;
                virusStrength += virus;
                virStr = virusStrength / 3;
                timeToDefeatInSec = (virStr * line.Length) / 3;
            }

            Math.Floor(health = health * 0.20 + health);

            if (health > 0)
            {
                if (health > startHealth)
                {
                    health = startHealth;
                }

                health = Math.Floor(health - timeToDefeatInSec);

                Console.WriteLine($"Virus {line}: {virStr} => {Math.Floor(timeToDefeatInSec):f0} seconds");
                Console.WriteLine($"{line} defeated in {Math.Floor(timeToDefeatInSec / 60):f0}m {Math.Floor(timeToDefeatInSec % 60):f0}s.");
                Console.WriteLine($"Remaining health: {Math.Floor(health):f0}");
            }
            else if (health < 0)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
        }
    }
}
