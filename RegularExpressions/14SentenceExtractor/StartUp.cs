namespace _14SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = $@"[^.!? ]* {word} [^.]*[\.?!]";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
