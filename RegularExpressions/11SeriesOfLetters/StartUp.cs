namespace _11SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(Regex.Replace(text, "([a-zA-Z])\\1+", "$1"));
        }
    }
}
