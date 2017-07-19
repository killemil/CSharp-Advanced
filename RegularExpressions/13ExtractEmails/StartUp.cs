namespace _13ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=^|[\s+])([A-Za-z0-9]+[-.\w]+@([\w]+[-\w]+[.]){1,2}[a-z]+)(?=$|[,.\s+])";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
