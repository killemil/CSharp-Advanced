namespace Quotations
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"('|"")(.*?)\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
            
        }
    }
}
