namespace _07.ValidTime
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"[0][0-9]:[0-5][0-9]:[0-5][0-9] [A|P]M|[1][0-2]:[0-5][0-9]:[0-5][0-9] [A|P]M";
            Regex regex = new Regex(pattern);

            while (!text.Equals("END"))
            {
                bool isValid = regex.IsMatch(text);
                if (isValid)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                text = Console.ReadLine();
            }
        }
    }
}
