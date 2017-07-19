namespace _19LettersChangeNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            double totalsum = 0.0;

            foreach (var word in text)
            {
                double currentSum = 0.0;
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    int charValue = alphabet.IndexOf(char.ToLower(firstLetter)) + 1;
                    currentSum = (double)(number / charValue);
                }
                else
                {
                    int charValue = alphabet.IndexOf(firstLetter) + 1;
                    currentSum = (double)(number * charValue);
                }

                if (char.IsUpper(lastLetter))
                {
                    int charValue = alphabet.IndexOf(char.ToLower(lastLetter)) + 1;
                    currentSum -= charValue;
                }
                else
                {
                    int charValue = alphabet.IndexOf(lastLetter) + 1;
                    currentSum += charValue;
                }
                totalsum += currentSum;
            }

            Console.WriteLine($"{totalsum:f2}");
        }
    }
}
