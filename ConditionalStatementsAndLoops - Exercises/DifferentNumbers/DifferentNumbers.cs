using System;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs (a - b) < 5)
            {
                Console.WriteLine("No");
            }

            for (int n1 = a; n1 <= b; n1++)
            {
                for (int n2 = a + 1; n2 < b; n2++)
                {
                    for (int n3 = a + 2; n3 <= b; n3++)
                    {
                        for (int n4 = a + 3; n4 <= b; n4++)
                        {
                            for (int n5 = a + 4; n5 <= b; n5++)
                            {
                                bool check = a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b;

                                if (check)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                }                               
                               
                            }
                        }
                    }
                }
            }
        }
    }
}
