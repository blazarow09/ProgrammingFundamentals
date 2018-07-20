using System;
using System.Collections.Generic;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Dictionary<string, string> emailsBook = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = "";
                email = Console.ReadLine();

                if (!emailsBook.ContainsKey(name))
                {
                    emailsBook.Add(name, email);
                }
                if (email.EndsWith("us")
                 || email.EndsWith("uk"))
                {
                    emailsBook.Remove(name, out email);
                }

                name = Console.ReadLine();
            }

            foreach (var emaill in emailsBook)
            {
                Console.WriteLine($"{emaill.Key} -> {emaill.Value}");
            }
        }
    }
}
