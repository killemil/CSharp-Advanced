namespace _03FirstName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split();
            string[] letters = Console.ReadLine().Split();
            List<string> result = new List<string>();

            foreach (var name in names)
            {
                foreach (var letter in letters)
                {
                    if (name.ToLower().StartsWith(letter.ToLower()))
                    {
                        result.Add(name);
                    }
                }
            }

            if (result.Any())
            {
                Console.WriteLine(string.Join("", result.OrderBy(n => n).Take(1)));
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
