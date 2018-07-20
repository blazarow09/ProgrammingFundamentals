using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var arr = new List<int>();

            
                arr.Add(int.Parse(input));



                

                arr.Reverse();
                Console.WriteLine(string.Join(" \n", arr));
            
        }
    }
}
