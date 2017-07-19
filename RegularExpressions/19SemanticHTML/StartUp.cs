namespace _19SemanticHTML
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string openTagPattern = @"<(div)([^>]+)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
            string closeTagPattern = @"<\/div>\s*<!--\s*(.*?)\s*-->";

            while (line != "END")
            {
                Match openingMatch = Regex.Match(line, openTagPattern);
                Match closingMath = Regex.Match(line, closeTagPattern);

                if (openingMatch.Success)
                {
                    line = Regex.Replace(line, openTagPattern, @"$3 $2 $4").Trim();
                    line = "<" + Regex.Replace(line, @"\s+", " ") + ">";
                }
                else if (closingMath.Success)
                {
                    line = "</" + closingMath.Groups[1].Value + ">";
                }
                Console.WriteLine(line);
                line = Console.ReadLine();
            }
        }
    }
}
