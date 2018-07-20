using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToLower().ToCharArray();
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", array[i], array[i] - 'a');
            }         
        }
    }
}
