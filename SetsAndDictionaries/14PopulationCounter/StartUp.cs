namespace _14PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> totalPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("report"))
            {
                string[] inputArgs = input
                    .Split('|');

                string country = inputArgs[1];
                string city = inputArgs[0];
                long population = long.Parse(inputArgs[2]);

                if (!totalPopulation.ContainsKey(country))
                {
                    totalPopulation[country] = new Dictionary<string, long>();
                    totalPopulation[country][city] = population;
                }
                else
                {
                    if (!totalPopulation[country].ContainsKey(city))
                    {
                        totalPopulation[country][city] = population;
                    }
                    else
                    {
                        totalPopulation[country][city] += population;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var country in totalPopulation.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(x => x.Value)})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
