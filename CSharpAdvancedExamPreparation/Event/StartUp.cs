namespace Event
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string pattern = @"^#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*([0-2][0-9]:[0-5][0-9])$";

            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, List<string>>> events = new SortedDictionary<string, SortedDictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    MatchCollection matches = Regex.Matches(input, pattern);
                    foreach (Match match in matches)
                    {
                        string name = match.Groups[1].Value;
                        string location = match.Groups[2].Value;
                        string time = match.Groups[3].Value;

                        if (int.Parse(time.Substring(0, 2)) > 23)
                        {
                            continue;
                        }

                        if (!events.ContainsKey(location))
                        {
                            events.Add(location, new SortedDictionary<string, List<string>>());
                        }
                        if (!events[location].ContainsKey(name))
                        {
                            events[location][name] = new List<string>();
                        }
                        events[location][name].Add(time);
                    }
                }
            }

            string[] requestedEvents = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var reqEvent in requestedEvents.OrderBy(c => c))
            {
                if (events.ContainsKey(reqEvent))
                {
                    int count = 1;
                    foreach (var ev in events.Where(e => e.Key == reqEvent))
                    {
                        Console.WriteLine($"{ev.Key}:");
                        foreach (var name in ev.Value)
                        {

                            Console.WriteLine($"{count}. {name.Key} -> {string.Join(", ", name.Value.OrderBy(c => c))}");
                            count++;
                        }
                    }
                }
            }
        }
    }
}
