using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniDayIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            decimal totalSum = 0;

            while (input != "end of shift")
            {
                string pattern = @"%(?<name>[A-z]{1}[a-z]+)%[^\|\$%\.]*?<(?<product>\w+)>[^\|\$%\.]*?\|(?<count>[0-9]+)\|[^\|\$%\.]*?(?<price>[0-9.0-9]+)\$";

                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    var name = match.Groups["name"].Value;
                    var product = match.Groups["product"].Value;
                    var count = match.Groups["count"].Value;
                    var price = match.Groups["price"].Value;

                    decimal totalPrice = decimal.Parse(count) * decimal.Parse(price);
                    totalSum += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
