using System;
using System.Linq;

namespace MostFrequentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int frequent = 0;
            int repetitions = 0;
            int currentNumber = 0;
            int counter = 0;
            for (int i = 0; i < array.Length ; i++)
            {
                 currentNumber = array[i];
                 counter = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (currentNumber == array[j])
                    {
                        counter++;
                    }
                }

                if (counter > repetitions)
                {
                    frequent = currentNumber;
                    repetitions = counter;
                }
            }
            Console.WriteLine(frequent);
        }
    }
}
