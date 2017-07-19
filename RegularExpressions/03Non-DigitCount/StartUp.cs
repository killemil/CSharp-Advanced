namespace _03Non_DigitCount
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\D";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
