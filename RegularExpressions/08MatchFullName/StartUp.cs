namespace _08MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            while (!text.Equals("end"))
            {
                MatchCollection matches = regex.Matches(text);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                text = Console.ReadLine();
            }

        }
    }
}
