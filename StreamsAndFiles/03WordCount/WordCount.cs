namespace _03WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            StreamReader words = new StreamReader("../../words.txt");
            StreamReader text = new StreamReader("../../text.txt");
            StreamWriter result = new StreamWriter("../../result.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            using (words)
            {
                using (text)
                {
                    string word = words.ReadLine();
                    while (word != null)
                    {
                        text.DiscardBufferedData();
                        text.BaseStream.Seek(0, SeekOrigin.Begin);
                        string textLine = text.ReadLine();

                        while (textLine != null)
                        {
                            string[] textLineTokens = textLine
                                .Split(new string[] { " ", ",", ".", "-", "...", "?!", "!", "?" }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                            foreach (var token in textLineTokens)
                            {
                                if (word.ToLower().Equals(token.ToLower()))
                                {
                                    if (!wordsCount.ContainsKey(word))
                                    {
                                        wordsCount[word] = 0;
                                    }
                                    wordsCount[word]++;
                                }
                            }
                            textLine = text.ReadLine();
                        }
                        word = words.ReadLine();
                    }
                }
            }
            using (result)
            {
                foreach (var word in wordsCount.OrderByDescending(w => w.Value))
                {
                    result.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
