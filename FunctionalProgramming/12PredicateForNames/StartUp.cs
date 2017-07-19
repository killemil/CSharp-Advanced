namespace _12PredicateForNames
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int len = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Print(names, len);
        }

        private static void Print(string[] names, int len)
        {
            Console.WriteLine(string.Join("\n", names.Where(w => w.Length <= len)));
        }
    }
}
