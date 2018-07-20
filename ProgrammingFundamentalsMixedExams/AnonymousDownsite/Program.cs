using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            var totalLoss = new List<decimal>();

            var data = new List<string>();

            var sites = new List<string>();

            for (int index = 0; index < n; index++)
            {
                data = Console.ReadLine().Split().ToList();
                var siteName = data[0];
                sites.Add(siteName);
                long siteVisits = long.Parse(data[1]);
                var sitePricePerVisit = decimal.Parse(data[2]);

                decimal loss = siteVisits * sitePricePerVisit;

                totalLoss.Add(loss);
            }

            decimal total = totalLoss.Sum();
            BigInteger secKey = BigInteger.Pow(new BigInteger(securityKey), n);

            Console.WriteLine(string.Join(Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {total:f20}");
            Console.WriteLine($"Security Token: {secKey}");

        }
    }
}
