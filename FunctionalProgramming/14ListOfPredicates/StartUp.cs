namespace _14ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int border = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> filter = (n, d) => n % d == 0;
            Print(border, dividers, filter);
        }

        private static void Print(int border, int[] dividers, Func<int, int, bool> filter)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= border; i++)
            {
                bool hasPassed = true;
                foreach (var divider in dividers)
                {
                    if (!filter(i, divider))
                    {
                        hasPassed = false;
                        break;
                    }
                }
                if (hasPassed)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
