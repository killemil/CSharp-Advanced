namespace _07PeriodicTable
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> compounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArgs = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in inputArgs)
                {
                    if (!compounds.Contains(item))
                    {
                        compounds.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", compounds));
        }
    }
}
