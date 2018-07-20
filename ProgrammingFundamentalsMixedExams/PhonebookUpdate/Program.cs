using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split().ToList();
                var command = tokens[0];

                if (command == "A")
                {
                var name = tokens[1];
                    var phone = tokens[2];
                    phonebook[name] = phone;
                }

                if (command == "ListAll")
                {
                    foreach (var contact in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                if (command == "S")
                {
                    var name = tokens[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}


