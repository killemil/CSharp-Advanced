namespace _15UnicodeCharacters
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = input.Select(w => $"\\u{Convert.ToUInt16(w):X4}").ToArray();
            foreach (var word in result)
            {
                Console.Write(word.ToLower());
            }
        }
    }
}
