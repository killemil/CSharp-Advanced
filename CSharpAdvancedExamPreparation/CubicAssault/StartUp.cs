namespace CubicAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static int ConvertThreshold = 1_000_000;

        static void Main()
        {
            List<string> meteors = new List<string>()
            {
                "Green",
                "Red",
                "Black"
            };
            Dictionary<string, Dictionary<string, long>> regions = new Dictionary<string, Dictionary<string, long>>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Count em all")
            {
                string[] tokens = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string regionName = tokens[0];
                string meteorType = tokens[1];
                long quantity = long.Parse(tokens[2]);

                if (!regions.ContainsKey(regionName))
                {
                    regions[regionName] = new Dictionary<string, long>()
                    {
                        { "Green", 0 },
                        { "Red", 0 },
                        { "Black", 0 }
                    };
                }

                regions[regionName][meteorType] += quantity;

                for (int i = 0; i < meteors.Count - 1; i++)
                {
                    var nextTypeCount = regions[regionName][meteors[i]] / ConvertThreshold;
                    if (nextTypeCount > 0)
                    {
                        regions[regionName][meteors[i + 1]] += nextTypeCount;
                        regions[regionName][meteors[i]] %= ConvertThreshold;
                    }
                }
            }

            var orderedRegions = regions
                .OrderByDescending(r => r.Value["Black"])
                .ThenBy(r => r.Key.Length)
                .ThenBy(r => r.Key)
                .ToDictionary(r => r.Key, r => r.Value);

            foreach (var r in orderedRegions)
            {
                Console.WriteLine(r.Key);
                foreach (var m in r.Value.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"-> {m.Key} : {m.Value}");
                }
            }
        }
    }
}
