namespace _18UseYourChainsBuddy
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"<p>(.*?)<\/p>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string newPattern = @"[^a-z0-9]";
                string result = Regex.Replace(match.Groups[1].Value, newPattern, " ");
                string whitespaces = @"\s+";
                result = Regex.Replace(result, whitespaces, " ");

                foreach (char character in result)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        Console.Write((char)(character + 13));
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        Console.Write((char)(character - 13));
                    }
                    else
                    {
                        Console.Write(character);
                    }
                }
            }
        }
    }
}
