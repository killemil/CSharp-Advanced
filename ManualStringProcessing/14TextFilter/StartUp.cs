namespace _14TextFilter
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string asterix = new string('*', word.Length);
                text = text.Replace(word, asterix);
            }

            Console.WriteLine(text);
        }
    }
}
