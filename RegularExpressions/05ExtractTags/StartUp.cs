namespace _05ExtractTags
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string textLine = Console.ReadLine();
            string pattern = @"<.*?>";
            Regex regex = new Regex(pattern);

            while (!textLine.Equals("END"))
            {
                bool isMatch = regex.IsMatch(textLine);
                if (isMatch)
                {
                    MatchCollection matches = regex.Matches(textLine);
                    foreach (var match in matches)
                    {

                        Console.WriteLine(match);
                    }
                }

                textLine = Console.ReadLine();
            }
        }
    }
}
