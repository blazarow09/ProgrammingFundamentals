using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Snowball
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong snowballSnow = 0;
            ulong snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;
            var summ = new List<BigInteger>();

            for (ulong index = 0; index < n; index++)
            {
                snowballSnow = ulong.Parse(Console.ReadLine());
                snowballTime = ulong.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                summ.Add(snowballValue);
            }

            Console.Write($"{snowballSnow} : {snowballTime} = ");
            Console.Write(string.Join("", summ.Max()));
            Console.Write($" ({snowballQuality})");
            Console.WriteLine();
        }
    }
}
