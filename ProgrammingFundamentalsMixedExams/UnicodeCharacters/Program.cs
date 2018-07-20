using System;
using System.Text;
namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int asciiNumberInDec = input[i] + 0;
                string asciiNumberInHex = asciiNumberInDec.ToString("X4");
                Console.Write("\\u" + asciiNumberInHex.ToLower());
            }
            Console.WriteLine();
        }
    }
}
