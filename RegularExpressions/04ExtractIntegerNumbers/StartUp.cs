
namespace _04ExtractIntegerNumbers
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
