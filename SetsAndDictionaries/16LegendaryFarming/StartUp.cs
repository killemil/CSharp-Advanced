namespace _16LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();
            Dictionary<string, int> keyItems = new Dictionary<string, int>();
            keyItems["shards"] = 0;
            keyItems["fragments"] = 0;
            keyItems["motes"] = 0;

            bool isFound = false;
            while (!isFound)
            {
                string[] inputArgs = Console.ReadLine()
                    .ToLower()
                    .Split();

                for (int i = 0; i < inputArgs.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        string material = inputArgs[i];
                        int quantity = int.Parse(inputArgs[i - 1]);
                        if (material.Equals("shards") ||
                            material.Equals("fragments") ||
                            material.Equals("motes"))
                        {

                            keyItems[material] += quantity;
                            if (keyItems[material] >= 250)
                            {
                                keyItems[material] -= 250;
                                ItemFound(material);
                                isFound = true;
                                break;
                            }
                        }
                        else
                        {
                            if (!junkItems.ContainsKey(material))
                            {
                                junkItems[material] = quantity;
                            }
                            else
                            {
                                junkItems[material] += quantity;
                            }
                        }
                    }
                }
            }

            foreach (var keyItem in keyItems.OrderByDescending(k => k.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{keyItem.Key}: {keyItem.Value}");
            }
            foreach (var junk in junkItems)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }

        private static void ItemFound(string material)
        {
            if (material.Equals("shards"))
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (material.Equals("fragments"))
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
        }
    }
}
