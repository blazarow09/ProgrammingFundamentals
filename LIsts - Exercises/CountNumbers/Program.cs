using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int count1 = 0; int count2 = 0; int count3 = 0; int count4 = 0; int count5 = 0; int count6 = 0; int count7 = 0; int count8 = 0; int count9 = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (i)
                {
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                    case 3:
                        count3++;
                        break;
                    case 4:
                        count4++;
                        break;
                    case 5:
                        count5++;
                        break;
                    case 6:
                        count6++;
                        break;
                    case 7:
                        count7++;
                        break;
                    case 8:
                        count8++;
                        break;
                    case 9:
                        count9++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
