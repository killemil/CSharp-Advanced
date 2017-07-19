namespace AshesOfRoses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string pattern = @"^Grow <([A-Z][a-z]+)> <([a-zA-Z0-9]+)> (\d+)$";
            string input = Console.ReadLine();

            SortedDictionary<string, SortedDictionary<string, long>> roses = new SortedDictionary<string, SortedDictionary<string, long>>();

            while (!input.Equals("Icarus, Ignite!"))
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string regionName = match.Groups[1].Value;
                    string colorName = match.Groups[2].Value;
                    int roseAmount;
                    bool hasParsed = int.TryParse(match.Groups[3].Value, out roseAmount);
                    if (hasParsed)
                    {
                        if (!roses.ContainsKey(regionName))
                        {
                            roses[regionName] = new SortedDictionary<string, long>();
                        }
                        if (!roses[regionName].ContainsKey(colorName))
                        {
                            roses[regionName][colorName] = 0;
                        }
                        roses[regionName][colorName] += roseAmount;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var region in roses.OrderByDescending(x => x.Value.Sum(c => c.Value)))
            {
                Console.WriteLine(region.Key);
                foreach (var color in region.Value.OrderBy(r => r.Value))
                {
                    Console.WriteLine($"*--{color.Key} | {color.Value}");
                }
            }
        }
    }
}
