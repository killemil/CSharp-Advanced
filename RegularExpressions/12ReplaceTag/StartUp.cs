namespace _12ReplaceTag
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string textLine = Console.ReadLine();
            string pattern = @"<a (href=.+?)>(.+?)<\/a>";

            while (!textLine.Equals("end"))
            {
                Console.WriteLine(Regex.Replace(textLine,pattern,"[URL $1]$2[/URL]"));

                textLine = Console.ReadLine();
            }
        }
    }
}
