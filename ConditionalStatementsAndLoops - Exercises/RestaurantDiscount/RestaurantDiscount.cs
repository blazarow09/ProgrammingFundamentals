using System;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0.0;
            double discount = 0.0;
            string hall = "";

            if (groupCount <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (groupCount > 50 && groupCount <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (groupCount > 100 && groupCount <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                price += 500;
                discount = price - (price * 0.05);
            }
            else if (package == "Gold")
            {
                price += 750;
                discount = price - (price * 0.1);
            }
            else if (package == "Platinum")
            {
                price += 1000;
                discount = price - (price * 0.15);
            }

            Console.WriteLine($"We can offer you the {hall}\nThe price per person is {discount / groupCount:f2}$");
        }
    }
}
