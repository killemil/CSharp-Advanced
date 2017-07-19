namespace _09FindEvensorOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            var numbers = Enumerable.Range(bounds[0], bounds[1] - bounds[0] + 1);

            Predicate<int> isOdd = n => n % 2 != 0;
            PrintEvenOrOddNumbers(numbers, command, isOdd);
        }

        private static void PrintEvenOrOddNumbers(IEnumerable<int> numbers, string command, Predicate<int> isOdd)
        {
            List<int> result = new List<int>();
            foreach (var num in numbers)
            {
                if (isOdd(num) && command == "odd")
                {
                    result.Add(num);
                }
                else if (!isOdd(num) && command == "even")
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
