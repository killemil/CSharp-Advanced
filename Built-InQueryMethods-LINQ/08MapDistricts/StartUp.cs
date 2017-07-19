namespace _08MapDistricts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<long>> result = new Dictionary<string, List<long>>();
            List<string> cities = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            long minimumPopulation = long.Parse(Console.ReadLine());

            foreach (var city in cities)
            {
                long delimeterIndex = city.IndexOf(':');
                string cityDistrict = city.Substring(0, (int)delimeterIndex);
                long population = long.Parse(city.Substring((int)delimeterIndex + 1));
                if (!result.ContainsKey(cityDistrict))
                {
                    result[cityDistrict] = new List<long>();
                }
                result[cityDistrict].Add(population);
            }

            foreach (var city in result.Where(c => c.Value.Sum() > minimumPopulation).OrderByDescending(c => c.Value.Sum()))
            {
                Console.WriteLine($"{city.Key}: {string.Join(" ", city.Value.OrderByDescending(p => p).Take(5))}");
            }
        }
    }
}
