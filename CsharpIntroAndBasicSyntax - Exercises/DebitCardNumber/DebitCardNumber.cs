using System;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstCouple = int.Parse(Console.ReadLine());
            int secondCouple = int.Parse(Console.ReadLine());
            int thirdCouple = int.Parse(Console.ReadLine());
            int forthCouple = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstCouple:d4} {secondCouple:d4} {thirdCouple:d4} {forthCouple:d4}");
        }
    }
}
