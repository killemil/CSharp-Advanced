namespace _13UserLogs
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> logs = new SortedDictionary<string, Dictionary<string, int>>();

            while (!input.Equals("end"))
            {
                string[] inputArgs = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string username = inputArgs[2].Substring(5);
                string ipAdress = inputArgs[0].Substring(3);

                if (!logs.ContainsKey(username))
                {
                    logs[username] = new Dictionary<string, int>();
                    logs[username][ipAdress] = 1;
                }
                else
                {
                    if (!logs[username].ContainsKey(ipAdress))
                    {
                        logs[username][ipAdress] = 1;
                    }
                    else
                    {
                        logs[username][ipAdress] += 1;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in logs)
            {
                int last = 1;
                Console.WriteLine($"{user.Key}: ");
                foreach (var ip in user.Value)
                {
                    if (user.Value.Count == last)
                    {
                        Console.Write($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    last++;
                }
                Console.WriteLine();
            }
        }
    }
}
