namespace _11CountSubstringOccurrences
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            int counter = 0;
            int startIndex = text.IndexOf(pattern, 0, StringComparison.OrdinalIgnoreCase);
            while (startIndex != -1)
            {
                counter++;
                startIndex = text.IndexOf(pattern, startIndex + 1, StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine(counter);
        }
    }
}
