
namespace _02VowelCount
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"[aeouiyAEOUIY]";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
