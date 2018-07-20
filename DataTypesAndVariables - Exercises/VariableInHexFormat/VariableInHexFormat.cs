using System;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
                     
                int number = Convert.ToInt32(value, 16);
                Console.WriteLine($"{number.ToString()}");
           
        }
    }
}