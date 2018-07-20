using System;

namespace ProgrammingFundamentalsExamTrains
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice= double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalExpense = 0;

            for (int index = 1; index <= lostGames; index++)
            {
                if (index % 2 == 0)
                {
                    totalExpense += headsetPrice;
                }

                if (index % 3 == 0)
                {
                    totalExpense += mousePrice;
                }

                if (index % 6 == 0)
                {
                    totalExpense += keyboardPrice;
                }

                if (index % 12 == 0)
                {
                    totalExpense += displayPrice;
                }

            }
                Console.WriteLine($"Rage expenses: {totalExpense:f2} lv.");

        }
    }
}
