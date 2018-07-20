using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEff = int.Parse(Console.ReadLine());
            int secondEmployeeEff = int.Parse(Console.ReadLine());
            int thirdEmployeeEff = int.Parse(Console.ReadLine());
            int customersCount = int.Parse(Console.ReadLine());

            int totStudentsPerHour = firstEmployeeEff + secondEmployeeEff + thirdEmployeeEff;

            int hours = 0;
            int sum = 0;
            int serviced = customersCount;

            while (true)
            {
                if (serviced < 1)
                {
                    Console.WriteLine($"Time needed: {hours:f0}h.");
                    return;
                }
                else
                {
                    sum = totStudentsPerHour * 1;
                    serviced -= sum;
                    hours++;

                    if (hours % 4 == 0)
                    {
                        hours++;
                    }
                }
            }
        }
    }
}
