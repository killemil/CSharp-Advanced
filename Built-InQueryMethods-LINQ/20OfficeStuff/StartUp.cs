namespace _20OfficeStuff
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, long>> companies = new SortedDictionary<string, Dictionary<string, long>>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { "|", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string company = input[0];
                long amount = long.Parse(input[1]);
                string product = input[2];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new Dictionary<string, long>();
                }
                if (!companies[company].ContainsKey(product))
                {
                    companies[company][product] = 0;
                }
                companies[company][product] += amount;
            }

            foreach (var company in companies)
            {
                Console.Write($"{company.Key}: ");
                List<string> products = new List<string>();
                foreach (var product in company.Value)
                {
                    products.Add(string.Format($"{product.Key}-{product.Value}"));
                }
                Console.WriteLine(string.Join(", ", products));
            }
        }
    }
}
