namespace _04SpecialWords
{
    using System;
    using System.Collections.Generic;

    public class Launcher
    {
        public static void Main()
        {
            char[] separators = new char[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' };

            string[] keyWords = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] text = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            foreach (var keyword in keyWords)
            {
                if (!wordCounter.ContainsKey(keyword))
                {
                    wordCounter[keyword] = 0;
                }
                foreach (var word in text)
                {
                    if (keyword.Equals(word))
                    {
                        wordCounter[keyword]++;
                    }
                }
            }

            foreach (var word in wordCounter)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }

        }
    }
}
