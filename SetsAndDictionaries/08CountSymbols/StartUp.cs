namespace _08CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> countSymbols = new SortedDictionary<char, int>();

            foreach (var ch in text)
            {
                if (!countSymbols.ContainsKey(ch))
                {
                    countSymbols[ch] = 1;
                }
                else
                {
                    countSymbols[ch]++;
                }
            }

            foreach (var item in countSymbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
