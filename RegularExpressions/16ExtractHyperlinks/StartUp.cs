namespace _16ExtractHyperlinks
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""""([^""""]*)""""|([^\s>]+))[^>]*>";
            Regex regex = new Regex(pattern);

            while (!text.Equals("END"))
            {
                MatchCollection matches = regex.Matches(text);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups[3].Value);
                }

                text = Console.ReadLine();
            }

        }
    }
}
