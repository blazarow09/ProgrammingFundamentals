using System;

namespace ChooseADrink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine($"The {proffesion} has to pay {count * 0.70:f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {proffesion} has to pay {count * 1.00:f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {proffesion} has to pay {count * 1.00:f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proffesion} has to pay {count * 1.70:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay {count * 1.20:f2}.");
                    break;
            }
        }
    }
}
