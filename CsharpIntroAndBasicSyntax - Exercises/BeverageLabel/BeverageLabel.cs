using System;

namespace BeverageLabel
{
    class BeverageLabel
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double  kcal = energy * volume / 100.0;
            double sugars = sugar * volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
