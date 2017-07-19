namespace _03CountUppercaseWords
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(w => char.IsUpper(w[0]))
            .ToList()
            .ForEach(w => Console.WriteLine(w));
        }
    }
}
