namespace _17QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"[^&?]+";
            Regex regex = new Regex(pattern);

            while (input != "END")
            {
                Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    if (match.ToString().Contains("="))
                    {
                        string whiteSpace = @"\+|%20";
                        string replaced = Regex.Replace(match.ToString(), whiteSpace, " ");
                        replaced = Regex.Replace(replaced, "\\s+", " ");
                        int index = replaced.IndexOf('=');
                        string key = replaced.Substring(0, index).Trim();
                        string value = replaced.Substring(index + 1).Trim();

                        if (!result.ContainsKey(key))
                        {
                            result[key] = new List<string>();
                        }
                        result[key].Add(value);
                    }
                }

                foreach (var item in result)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }

        }
    }
}
