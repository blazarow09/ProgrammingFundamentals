﻿using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger factorial = 1;
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}