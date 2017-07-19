namespace _16Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            char[] separators = new char[] { ',', ' ', '!', '.', '?', };
            string[] input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> words = new List<string>();

            foreach (var word in input)
            {
                bool isPalindrome = IsPalindrome(word);
                if (isPalindrome)
                {
                    words.Add(word);
                }
            }

            string[] result = words.Distinct().OrderBy(x => x).ToArray();
            Console.WriteLine($"[{string.Join(", ", result)}]");

        }
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
