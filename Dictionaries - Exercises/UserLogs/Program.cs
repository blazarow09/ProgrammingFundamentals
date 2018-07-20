using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, List<string>>();


            string command = Console.ReadLine();
            while (true)
            {
                if (command == "end") break;

                var input = command.Split('=').ToList();

                string[] indexOfIP = command.Split('=');
                string ip = indexOfIP[1];
                var newIp = ip.Split();
                var IPP = newIp[0];
                var indexOfUser = command.Split("=", ' ');
                string user = indexOfUser[3];


                var IP = new List<string>();
                IP.Add(IPP);

                if (!users.ContainsKey(user))
                {
                    users[user] = IP;
                }
                else
                {
                    users[user].AddRange(IP);
                }
                command = Console.ReadLine();
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ": ");
                List<string> IPs = user.Value;
                var numberOfIPs = new Dictionary<string, int>();

                foreach (var ip in IPs)
                {
                    if (!numberOfIPs.ContainsKey(ip))
                    {
                        numberOfIPs[ip] = 1;
                    }
                    else
                    {
                        numberOfIPs[ip] += 1;
                    }
                }

                int count = numberOfIPs.Count;
                foreach (var ip in numberOfIPs)
                {
                    count--;
                    if (count > 0)
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ", ");
                    }
                    else
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}