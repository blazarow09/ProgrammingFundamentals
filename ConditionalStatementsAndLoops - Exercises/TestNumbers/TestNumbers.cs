using System;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 1;
            int i;
            int j;

            for (i = n; i >= 1; i--)
            {
                for (j = 1; j <= m; j++)
                {
                    sum += sum = 3 * (i * j);

                    if (sum >= max)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return;
                    }
                    counter++;
                }
            }
            if (sum < max)
            {
                Console.WriteLine($"{counter - 1} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
