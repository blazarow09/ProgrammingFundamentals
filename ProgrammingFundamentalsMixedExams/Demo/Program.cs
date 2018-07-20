using System;

namespace Creditsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double credits = 0.0;
            double sumOcenki = 0.0;
            for (int i = 1; i <= n; i++)
            {
                string number = Console.ReadLine();

                string firtDigit = (number[0].ToString());
                string secondDigit = (number[1].ToString());
                int thirdDigit = int.Parse(number[2].ToString());

                int sumTwo = int.Parse(firtDigit + secondDigit);

                if (thirdDigit == 2)
                {
                    sumOcenki += thirdDigit;

                }
                else if (thirdDigit == 3)
                {
                    sumOcenki += thirdDigit;
                    credits = n * (0.5 * sumTwo);
                }
                else if (thirdDigit == 4)
                {
                    sumOcenki += thirdDigit;
                    credits = n * (0.7 * sumTwo);
                }
                else if (thirdDigit == 5)
                {
                    sumOcenki += thirdDigit;
                    credits = n * (0.85 * sumTwo);
                }
                else if (thirdDigit == 6)
                {
                    sumOcenki += thirdDigit;
                    credits = sumTwo;
                }
            }
            Console.WriteLine("{0:f2}", credits);
            Console.WriteLine($"{sumOcenki / n:f2}");
        }
    }
}
