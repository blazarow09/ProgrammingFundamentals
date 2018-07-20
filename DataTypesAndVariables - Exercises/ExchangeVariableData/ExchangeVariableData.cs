using System;

namespace ExchangeVariableData
{
    class ExchangeVariableData
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            int helper;

            Console.WriteLine($"Before:\na = {num1}\nb = {num2}");

            helper = num1;
            num1 = num2;
            num2 = helper;

            Console.WriteLine($"After:\na = {num1}\nb = {num2}");
        }
    }
}
