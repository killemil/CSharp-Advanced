namespace _07KnightsOfHonor
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Print(names);
        }

        private static void Print(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
