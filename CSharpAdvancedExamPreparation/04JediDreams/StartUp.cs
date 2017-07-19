namespace _04JediDreams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            SortedDictionary<string, List<string>> result = new SortedDictionary<string, List<string>>();

            Regex methodDeclarationPattern = new Regex(@"static\s+.*?\s+([a-zA-Z]*[A-Z]{1}[a-zA-Z]*)\s*\(");
            Regex methodCallPattern = new Regex(@"([a-zA-Z]*[A-Z]+[a-zA-Z]*)\s*\(");

            string currentMethod = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                string inputLine = Console.ReadLine();

                if (methodDeclarationPattern.IsMatch(inputLine))
                {
                    Match methodDeclarationMatch = methodDeclarationPattern.Match(inputLine);

                    currentMethod = methodDeclarationMatch.Groups[1].Value;

                    if (!result.ContainsKey(currentMethod))
                    {
                        result.Add(currentMethod, new List<string>());
                    }
                }
                else if (methodCallPattern.IsMatch(inputLine) && currentMethod != string.Empty)
                {
                    MatchCollection currentMethodCallMatches = methodCallPattern.Matches(inputLine);

                    foreach (Match currentMethodCallMatch in currentMethodCallMatches)
                    {
                        result[currentMethod].Add(currentMethodCallMatch.Groups[1].Value);
                    }

                }
            }

            foreach (var method in result.OrderByDescending(c => c.Value.Count()))
            {
                if (method.Value.Count > 0)
                {
                    Console.WriteLine($"{method.Key} -> {method.Value.Count()} -> {string.Join(", ", method.Value.OrderBy(x => x))}");
                }
                else
                {
                    Console.WriteLine($"{method.Key} -> None");
                }
            }
        }
    }
}
