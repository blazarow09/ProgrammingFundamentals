using System;

namespace WordInPlural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                string remove = noun.Remove(noun.Length - 1);       
                Console.WriteLine($"{remove + "ies"}");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.WriteLine($"{noun + "es"}");
            }
            else
            {
                Console.WriteLine($"{noun + "s"}");
            }
           
        }
    }
}
