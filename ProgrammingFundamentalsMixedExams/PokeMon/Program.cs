using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTarget = int.Parse(Console.ReadLine());
            int yFactor = int.Parse(Console.ReadLine());

            int counter = 0;
            var equal = pokePower / 2;

            while (pokePower >= pokeTarget)
            {
                pokePower = Math.Abs(pokePower - pokeTarget);
                counter++;

                if (pokePower == equal)
                {
                    pokePower = Math.Abs(pokePower / yFactor);
                }
            }


            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
