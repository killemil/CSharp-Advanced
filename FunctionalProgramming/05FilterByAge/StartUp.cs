namespace _05FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                result.Add(name, age);
            }
            string condition = Console.ReadLine();
            int years = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (condition.Equals("older"))
            {
                result = result.Where(x => x.Value >= years).ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                result = result.Where(x => x.Value < years).ToDictionary(x => x.Key, x => x.Value);
            }

            Print(result, format);
        }

        private static void Print(Dictionary<string, int> result, string format)
        {
            switch (format)
            {
                case "name":
                    Console.WriteLine(string.Join("\n", result.Keys));
                    break;
                case "age":
                    Console.WriteLine(string.Join("\n", result.Values));
                    break;
                case "name age":
                    foreach (var items in result)
                    {
                        Console.WriteLine($"{items.Key} - {items.Value}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
