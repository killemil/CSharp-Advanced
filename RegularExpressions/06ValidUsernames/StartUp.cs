namespace _06ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"^[\w-]{3,16}$";
            Regex regex = new Regex(pattern);

            while (!text.Equals("END"))
            {
                bool isMatch = regex.IsMatch(text);
                if (isMatch)
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
