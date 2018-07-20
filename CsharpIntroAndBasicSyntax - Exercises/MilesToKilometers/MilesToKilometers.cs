using System;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine($"{miles * 1.60934:f2}");
        }
    }
}
