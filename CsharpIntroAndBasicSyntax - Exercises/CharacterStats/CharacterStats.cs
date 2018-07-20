using System;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int MaxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int MaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}" +
                    $"\nHealth: |{new string('|', health)}{new string('.', MaxHealth - health)}|" +
                    $"\nEnergy: |{new string('|', energy)}{new string('.', MaxEnergy - energy)}|");

        }
    }
}
