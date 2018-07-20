using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = Console.ReadLine();

            var database = new Dictionary<string, Dictionary<double, double>>();

            var totalAmount = 0.0;

            while (lines != "stocked")
            {
                var line = lines.Split().ToArray();
                var item = line[0];
                double price = double.Parse(line[1]);
                double quantity = double.Parse(line[2]);

                if (!database.ContainsKey(item))
                {
                    database[item] = new Dictionary<double, double>(); //adding item 
                }

                if (!database[item].ContainsKey(price))
                {
                    database[item][price] = 0; //adding the price 
                }

                database[item][price] += quantity;

                lines = Console.ReadLine();
            }

            foreach (var items in database)
            {
                var nameOfProduct = items.Key;
                var price = items.Value.Keys.Last();
                var quantity = items.Value.Values.Sum();
                totalAmount += (quantity * price);
                Console.WriteLine($"{nameOfProduct}: ${price:f2} * {quantity} = ${quantity * price:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalAmount:f2}");
        }
    }
}
