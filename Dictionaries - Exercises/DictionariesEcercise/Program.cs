using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesEcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            string command = Console.ReadLine();

            while (!(command == "END"))
            {
                string[] splitedCommand = command.Split().ToArray();

                if (splitedCommand[0] == "S")
                {
                    if (!phonebook.ContainsKey(splitedCommand[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.", splitedCommand[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", splitedCommand[1], phonebook[splitedCommand[1]]);
                    }
                }
                else
                {
                    phonebook[splitedCommand[1]] = splitedCommand[2];
                }



                command = Console.ReadLine();
            }
        }
    }
}
