namespace _15LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ipAdress = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);

                if (!logs.ContainsKey(username))
                {
                    logs[username] = new SortedDictionary<string, int>();
                    logs[username][ipAdress] = duration;
                }
                else
                {
                    if (!logs[username].ContainsKey(ipAdress))
                    {
                        logs[username][ipAdress] = duration;
                    }
                    else
                    {
                        logs[username][ipAdress] += duration;
                    }
                }
            }

            foreach (var log in logs)
            {
                int count = 1;
                Console.Write($"{log.Key}: {log.Value.Values.Sum()} [");
                foreach (var ip in log.Value)
                {
                    if (log.Value.Count == count)
                    {
                        Console.WriteLine($"{ip.Key}]");
                    }
                    else
                    {
                        Console.Write($"{ip.Key}, ");
                    }
                    count++;
                }
            }
        }
    }
}
