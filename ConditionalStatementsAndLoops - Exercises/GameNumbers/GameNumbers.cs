using System;

namespace GameNumbers
{
    class GameNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int counter = 0;
            int i;            
            int j;
            bool check = false;
            for ( i = n; i <= m; i++)
            {
                for ( j = n; j <= m; j++)
                {
                    check = i + j == magic;
                    if (check)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magic}");
                        return;
                    }                                                          
                    counter++;
                }
            }
            if (check == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }           
        }
    }
}
