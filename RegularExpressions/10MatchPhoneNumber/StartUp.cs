namespace _10MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string textLine = Console.ReadLine();
            string pattern = @"\+359( |-)[2]\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);

            while (!textLine.Equals("end"))
            {
                MatchCollection matches = regex.Matches(textLine);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                textLine = Console.ReadLine();
            }
        }
    }
}
