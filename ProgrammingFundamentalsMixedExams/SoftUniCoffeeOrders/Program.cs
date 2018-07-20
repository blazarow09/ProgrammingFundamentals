using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal pricePerCoffee = 0;
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine();
                uint capsulesCount = uint.Parse(Console.ReadLine());

                var tokens = orderDate.Split('/').ToList();
                var month = int.Parse(tokens[1]);
                var year = int.Parse(tokens[2]);
                var daysInMonth = DateTime.DaysInMonth(year, month);

                pricePerCoffee = (daysInMonth * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${pricePerCoffee:f2}");
                totalPrice += pricePerCoffee;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
