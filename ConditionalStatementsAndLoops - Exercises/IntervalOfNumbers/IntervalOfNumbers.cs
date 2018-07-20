using System;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum < secondNum)
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    Console.WriteLine(i);
                }              
            }
            else if (firstNum > secondNum)
            {
                for (int i = secondNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
