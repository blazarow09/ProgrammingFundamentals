using System;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            
            for (int i = 0; i < input.Length; i++)
            {
                 int number = int.Parse(Console.ReadLine());

                input[input.Length - 1 - i] = number;
                
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
